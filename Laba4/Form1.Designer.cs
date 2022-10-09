
namespace Laba4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_clear_canvas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectedPrm = new System.Windows.Forms.RadioButton();
            this.rbPolygon = new System.Windows.Forms.RadioButton();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.rbPoint = new System.Windows.Forms.RadioButton();
            this.button_create_new_polygon = new System.Windows.Forms.Button();
            this.button_find_crossing_lines = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(232, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(556, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button_clear_canvas
            // 
            this.button_clear_canvas.Location = new System.Drawing.Point(12, 12);
            this.button_clear_canvas.Name = "button_clear_canvas";
            this.button_clear_canvas.Size = new System.Drawing.Size(214, 23);
            this.button_clear_canvas.TabIndex = 1;
            this.button_clear_canvas.Text = "Очистить канвас";
            this.button_clear_canvas.UseVisualStyleBackColor = true;
            this.button_clear_canvas.Click += new System.EventHandler(this.button_clear_canvas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectedPrm);
            this.groupBox1.Controls.Add(this.rbPolygon);
            this.groupBox1.Controls.Add(this.rbLine);
            this.groupBox1.Controls.Add(this.rbPoint);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // selectedPrm
            // 
            this.selectedPrm.AutoSize = true;
            this.selectedPrm.Location = new System.Drawing.Point(37, 19);
            this.selectedPrm.Name = "selectedPrm";
            this.selectedPrm.Size = new System.Drawing.Size(121, 17);
            this.selectedPrm.TabIndex = 4;
            this.selectedPrm.TabStop = true;
            this.selectedPrm.Text = "Выбрать приметив";
            this.selectedPrm.UseVisualStyleBackColor = true;
            // 
            // rbPolygon
            // 
            this.rbPolygon.AutoSize = true;
            this.rbPolygon.Location = new System.Drawing.Point(37, 88);
            this.rbPolygon.Name = "rbPolygon";
            this.rbPolygon.Size = new System.Drawing.Size(147, 17);
            this.rbPolygon.TabIndex = 2;
            this.rbPolygon.TabStop = true;
            this.rbPolygon.Text = "Создать многоугольник";
            this.rbPolygon.UseVisualStyleBackColor = true;
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Location = new System.Drawing.Point(37, 65);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(111, 17);
            this.rbLine.TabIndex = 1;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Создать отрезок";
            this.rbLine.UseVisualStyleBackColor = true;
            // 
            // rbPoint
            // 
            this.rbPoint.AutoSize = true;
            this.rbPoint.Location = new System.Drawing.Point(37, 42);
            this.rbPoint.Name = "rbPoint";
            this.rbPoint.Size = new System.Drawing.Size(97, 17);
            this.rbPoint.TabIndex = 0;
            this.rbPoint.TabStop = true;
            this.rbPoint.Text = "Создать точку";
            this.rbPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbPoint.UseVisualStyleBackColor = true;
            // 
            // button_create_new_polygon
            // 
            this.button_create_new_polygon.Location = new System.Drawing.Point(12, 175);
            this.button_create_new_polygon.Name = "button_create_new_polygon";
            this.button_create_new_polygon.Size = new System.Drawing.Size(214, 23);
            this.button_create_new_polygon.TabIndex = 2;
            this.button_create_new_polygon.Text = "Создать новый многоугольник";
            this.button_create_new_polygon.UseVisualStyleBackColor = true;
            this.button_create_new_polygon.Click += new System.EventHandler(this.button_create_new_polygon_Click);
            // 
            // button_find_crossing_lines
            // 
            this.button_find_crossing_lines.Location = new System.Drawing.Point(12, 204);
            this.button_find_crossing_lines.Name = "button_find_crossing_lines";
            this.button_find_crossing_lines.Size = new System.Drawing.Size(214, 23);
            this.button_find_crossing_lines.TabIndex = 3;
            this.button_find_crossing_lines.Text = "Найти пересечение двух ребер";
            this.button_find_crossing_lines.UseVisualStyleBackColor = true;
            this.button_find_crossing_lines.Click += new System.EventHandler(this.button_find_crossing_lines_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_find_crossing_lines);
            this.Controls.Add(this.button_create_new_polygon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_clear_canvas);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_clear_canvas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPolygon;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.RadioButton rbPoint;
        private System.Windows.Forms.Button button_create_new_polygon;
        private System.Windows.Forms.Button button_find_crossing_lines;
        private System.Windows.Forms.RadioButton selectedPrm;
    }
}

