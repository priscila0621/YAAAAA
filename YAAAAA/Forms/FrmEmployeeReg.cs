﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YAAAAA.Models;
using YAAAAA.Services;

namespace YAAAAA.Forms
{
    public partial class FrmEmployeeReg : Form
    {
        public bool IsEditMode { get; set; } = false;
        public FrmEmployeeReg()
        {
            InitializeComponent();
            CbArea.Items.AddRange(new string[] { "Preescolar", "Primaria", "Mantenimiento", "Limpieza", "Coordinacion", "Direccion" });
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos requeridos estén llenos
            if (string.IsNullOrWhiteSpace(TbNames.Text) ||
                string.IsNullOrWhiteSpace(TbLastNames.Text) ||
                string.IsNullOrWhiteSpace(TbIdNumber.Text) ||
                string.IsNullOrWhiteSpace(TbPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(TbEmail.Text) ||
                string.IsNullOrWhiteSpace(TbAddress.Text) ||
                string.IsNullOrWhiteSpace(CbArea.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Crear un nuevo objeto empleado con los datos ingresados
                Employee employee = new Employee
                {
                    EmployeeID = TbID.Text,
                    Names = TbNames.Text,
                    LastNames = TbLastNames.Text,
                    IdNumber = TbIdNumber.Text,
                    Birthdate = DtpBirthdate.Value,
                    PhoneNumber = TbPhoneNumber.Text,
                    Email = TbEmail.Text,
                    Address = TbAddress.Text,
                    Area = CbArea.Text,
                    HiringDate = DtpHiringDate.Value
                };

                // Verificar si el formulario está en modo de edición
                if (IsEditMode)
                {
                    // Actualizar el empleado existente
                    EmployeeService.UpdateEmployee(employee);
                    MessageBox.Show("Empleado actualizado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Resetear el modo de edición
                    IsEditMode = false;
                }
                else
                {
                    // Agregar un nuevo empleado
                    EmployeeService.AddEmployee(employee);
                    MessageBox.Show("Empleado registrado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Limpiar los campos para permitir una nueva entrada
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar el empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ClearFields()
        {
            TbID.Clear();
            TbNames.Clear();
            TbLastNames.Clear();
            TbIdNumber.Clear();
            DtpBirthdate.Value = DateTime.Now;
            TbPhoneNumber.Clear();
            TbEmail.Clear();
            TbAddress.Clear();
            CbArea.SelectedIndex = -1; // Restablecer el ComboBox
            DtpHiringDate.Value = DateTime.Now;

        }

        private void MnuSeeRegister_Click(object sender, EventArgs e)
        {
            FrmRegister registerForm = new FrmRegister();
            registerForm.Show();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // Confirmar si el usuario desea salir sin guardar
            DialogResult result = MessageBox.Show("¿Está seguro de que desea salir sin guardar los cambios?",
                                                  "Confirmación",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close(); // Cerrar el formulario
            }
        }

        private bool ValidarDatos()
        {
            
            if (TbNames.Text.Length > 50)
            {
                MessageBox.Show("El nombre no puede exceder los 50 caracteres.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

           
            if (TbLastNames.Text.Length > 50)
            {
                MessageBox.Show("Los apellidos no pueden exceder los 50 caracteres.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (TbIdNumber.Text.Length != 12)
            {
                MessageBox.Show("Ingrese una cédula válida", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            
            if (TbPhoneNumber.Text.Length != 8 || !TbPhoneNumber.Text.All(char.IsDigit))
            {
                MessageBox.Show("Ingrese un número de telefono válido", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            
            if (TbAddress.Text.Length > 100)
            {
                MessageBox.Show("La dirección no puede exceder los 100 caracteres.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (TbID.Text.Length > 50)
            {
                MessageBox.Show("El ID no puede exceder los 50 caracteres.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            
            return true;
        }
        private void TbNames_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
