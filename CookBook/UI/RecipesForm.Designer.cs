namespace CookBook.UI
{
    partial class RecipesForm
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
            RecipesFilterCbx = new ComboBox();
            RecipeTypesCbx = new ComboBox();
            DescriptionTxt = new RichTextBox();
            RecipePictureBox = new PictureBox();
            AddRecipeTypeBtn = new Button();
            RecipesGrid = new DataGridView();
            AddRecipeBtn = new Button();
            RecipeIngredientsBtn = new Button();
            ClearAllFieldsBtn = new Button();
            NameTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)RecipePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RecipesGrid).BeginInit();
            SuspendLayout();
            // 
            // RecipesFilterCbx
            // 
            RecipesFilterCbx.FormattingEnabled = true;
            RecipesFilterCbx.Location = new Point(12, 12);
            RecipesFilterCbx.Name = "RecipesFilterCbx";
            RecipesFilterCbx.Size = new Size(506, 38);
            RecipesFilterCbx.TabIndex = 0;
            // 
            // RecipeTypesCbx
            // 
            RecipeTypesCbx.FormattingEnabled = true;
            RecipeTypesCbx.Location = new Point(673, 62);
            RecipeTypesCbx.Name = "RecipeTypesCbx";
            RecipeTypesCbx.Size = new Size(121, 38);
            RecipeTypesCbx.TabIndex = 1;
            // 
            // DescriptionTxt
            // 
            DescriptionTxt.Location = new Point(673, 106);
            DescriptionTxt.Name = "DescriptionTxt";
            DescriptionTxt.Size = new Size(228, 71);
            DescriptionTxt.TabIndex = 2;
            DescriptionTxt.Text = "";
            // 
            // RecipePictureBox
            // 
            RecipePictureBox.Location = new Point(673, 183);
            RecipePictureBox.Name = "RecipePictureBox";
            RecipePictureBox.Size = new Size(228, 101);
            RecipePictureBox.TabIndex = 3;
            RecipePictureBox.TabStop = false;
            // 
            // AddRecipeTypeBtn
            // 
            AddRecipeTypeBtn.Location = new Point(800, 62);
            AddRecipeTypeBtn.Name = "AddRecipeTypeBtn";
            AddRecipeTypeBtn.Size = new Size(101, 38);
            AddRecipeTypeBtn.TabIndex = 4;
            AddRecipeTypeBtn.Text = "Add";
            AddRecipeTypeBtn.UseVisualStyleBackColor = true;
            AddRecipeTypeBtn.Click += AddRecipeTypeBtn_Click;
            // 
            // RecipesGrid
            // 
            RecipesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RecipesGrid.Location = new Point(12, 74);
            RecipesGrid.Name = "RecipesGrid";
            RecipesGrid.RowTemplate.Height = 25;
            RecipesGrid.Size = new Size(506, 338);
            RecipesGrid.TabIndex = 5;
            // 
            // AddRecipeBtn
            // 
            AddRecipeBtn.Location = new Point(534, 290);
            AddRecipeBtn.Name = "AddRecipeBtn";
            AddRecipeBtn.Size = new Size(367, 36);
            AddRecipeBtn.TabIndex = 6;
            AddRecipeBtn.Text = "Add recipe";
            AddRecipeBtn.UseVisualStyleBackColor = true;
            AddRecipeBtn.Click += AddRecipeBtn_Click;
            // 
            // RecipeIngredientsBtn
            // 
            RecipeIngredientsBtn.Location = new Point(534, 332);
            RecipeIngredientsBtn.Name = "RecipeIngredientsBtn";
            RecipeIngredientsBtn.Size = new Size(367, 36);
            RecipeIngredientsBtn.TabIndex = 7;
            RecipeIngredientsBtn.Text = "Recipe ingredients";
            RecipeIngredientsBtn.UseVisualStyleBackColor = true;
            // 
            // ClearAllFieldsBtn
            // 
            ClearAllFieldsBtn.Location = new Point(534, 376);
            ClearAllFieldsBtn.Name = "ClearAllFieldsBtn";
            ClearAllFieldsBtn.Size = new Size(367, 36);
            ClearAllFieldsBtn.TabIndex = 8;
            ClearAllFieldsBtn.Text = "Clear all fields";
            ClearAllFieldsBtn.UseVisualStyleBackColor = true;
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(673, 17);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(228, 35);
            NameTxt.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(544, 20);
            label1.Name = "label1";
            label1.Size = new Size(74, 30);
            label1.TabIndex = 10;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(544, 70);
            label2.Name = "label2";
            label2.Size = new Size(61, 30);
            label2.TabIndex = 11;
            label2.Text = "Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(544, 130);
            label3.Name = "label3";
            label3.Size = new Size(123, 30);
            label3.TabIndex = 12;
            label3.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(544, 225);
            label4.Name = "label4";
            label4.Size = new Size(76, 30);
            label4.TabIndex = 13;
            label4.Text = "Image:";
            // 
            // RecipesForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 415);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NameTxt);
            Controls.Add(ClearAllFieldsBtn);
            Controls.Add(RecipeIngredientsBtn);
            Controls.Add(AddRecipeBtn);
            Controls.Add(RecipesGrid);
            Controls.Add(AddRecipeTypeBtn);
            Controls.Add(RecipePictureBox);
            Controls.Add(DescriptionTxt);
            Controls.Add(RecipeTypesCbx);
            Controls.Add(RecipesFilterCbx);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "RecipesForm";
            Text = "RecipesForm";
            Load += RecipesForm_Load;
            ((System.ComponentModel.ISupportInitialize)RecipePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)RecipesGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox RecipesFilterCbx;
        private ComboBox RecipeTypesCbx;
        private RichTextBox DescriptionTxt;
        private PictureBox RecipePictureBox;
        private Button AddRecipeTypeBtn;
        private DataGridView RecipesGrid;
        private Button AddRecipeBtn;
        private Button RecipeIngredientsBtn;
        private Button ClearAllFieldsBtn;
        private TextBox NameTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}