namespace CookBook.UI
{
    partial class RecipeTypesFrom
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
            NewTypeTxt = new TextBox();
            label1 = new Label();
            RecipeTypesLbx = new ListBox();
            AddRecipeTypeBtn = new Button();
            SuspendLayout();
            // 
            // NewTypeTxt
            // 
            NewTypeTxt.Location = new Point(95, 32);
            NewTypeTxt.Name = "NewTypeTxt";
            NewTypeTxt.Size = new Size(206, 35);
            NewTypeTxt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 32);
            label1.Name = "label1";
            label1.Size = new Size(61, 30);
            label1.TabIndex = 1;
            label1.Text = "Type:";
            // 
            // RecipeTypesLbx
            // 
            RecipeTypesLbx.FormattingEnabled = true;
            RecipeTypesLbx.ItemHeight = 30;
            RecipeTypesLbx.Location = new Point(21, 87);
            RecipeTypesLbx.Name = "RecipeTypesLbx";
            RecipeTypesLbx.Size = new Size(283, 214);
            RecipeTypesLbx.TabIndex = 2;
            // 
            // AddRecipeTypeBtn
            // 
            AddRecipeTypeBtn.Location = new Point(23, 316);
            AddRecipeTypeBtn.Name = "AddRecipeTypeBtn";
            AddRecipeTypeBtn.Size = new Size(281, 41);
            AddRecipeTypeBtn.TabIndex = 3;
            AddRecipeTypeBtn.Text = "Add";
            AddRecipeTypeBtn.UseVisualStyleBackColor = true;
            AddRecipeTypeBtn.Click += AddRecipeTypeBtn_Click;
            // 
            // RecipeTypesFrom
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 375);
            Controls.Add(AddRecipeTypeBtn);
            Controls.Add(RecipeTypesLbx);
            Controls.Add(label1);
            Controls.Add(NewTypeTxt);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "RecipeTypesFrom";
            Text = "RecipeTypesFrom";
            Load += RecipeTypesFrom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NewTypeTxt;
        private Label label1;
        private ListBox RecipeTypesLbx;
        private Button AddRecipeTypeBtn;
    }
}