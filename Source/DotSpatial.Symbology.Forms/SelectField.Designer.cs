﻿using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DotSpatial.Symbology.Forms
{
    public partial class SelectField
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(SelectField));
            this.lblField = new Label();
            this.cmbField = new ComboBox();
            this.lblName = new Label();
            this.txtName = new TextBox();
            this.btnCancel = new Button();
            this.btnOK = new Button();
            this.SuspendLayout();
            //
            // lblField
            //
            this.lblField.AccessibleDescription = null;
            this.lblField.AccessibleName = null;
            resources.ApplyResources(this.lblField, "lblField");
            this.lblField.Font = null;
            this.lblField.Name = "lblField";
            //
            // cmbField
            //
            this.cmbField.AccessibleDescription = null;
            this.cmbField.AccessibleName = null;
            resources.ApplyResources(this.cmbField, "cmbField");
            this.cmbField.BackgroundImage = null;
            this.cmbField.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbField.Font = null;
            this.cmbField.FormattingEnabled = true;
            this.cmbField.Name = "cmbField";
            //
            // lblName
            //
            this.lblName.AccessibleDescription = null;
            this.lblName.AccessibleName = null;
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Font = null;
            this.lblName.Name = "lblName";
            //
            // txtName
            //
            this.txtName.AccessibleDescription = null;
            this.txtName.AccessibleName = null;
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.BackgroundImage = null;
            this.txtName.Font = null;
            this.txtName.Name = "txtName";
            //
            // btnCancel
            //
            this.btnCancel.AccessibleDescription = null;
            this.btnCancel.AccessibleName = null;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackgroundImage = null;
            this.btnCancel.Font = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new EventHandler(this.BtnCancelClick);
            //
            // btnOK
            //
            this.btnOK.AccessibleDescription = null;
            this.btnOK.AccessibleName = null;
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.BackgroundImage = null;
            this.btnOK.Font = null;
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new EventHandler(this.BtnOkClick);
            //
            // SelectField
            //
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");

            this.BackgroundImage = null;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmbField);
            this.Controls.Add(this.lblField);
            this.Font = null;
            this.Icon = null;
            this.Name = "SelectField";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnOK;
        private ComboBox cmbField;
        private Label lblField;
        private Label lblName;
        private TextBox txtName;
    }
}