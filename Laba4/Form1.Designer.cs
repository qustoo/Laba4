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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_distance_from_line_to_point = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rotate_input = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.scale_y_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.scale_x_input = new System.Windows.Forms.TextBox();
            this.afin_submit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.move_y_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.move_x_input = new System.Windows.Forms.TextBox();
            this.button_point_in_plg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(309, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(741, 725);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button_clear_canvas
            // 
            this.button_clear_canvas.Location = new System.Drawing.Point(16, 15);
            this.button_clear_canvas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_clear_canvas.Name = "button_clear_canvas";
            this.button_clear_canvas.Size = new System.Drawing.Size(285, 28);
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
            this.groupBox1.Location = new System.Drawing.Point(16, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(267, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // selectedPrm
            // 
            this.selectedPrm.AutoSize = true;
            this.selectedPrm.Location = new System.Drawing.Point(40, 23);
            this.selectedPrm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectedPrm.Name = "selectedPrm";
            this.selectedPrm.Size = new System.Drawing.Size(153, 21);
            this.selectedPrm.TabIndex = 4;
            this.selectedPrm.TabStop = true;
            this.selectedPrm.Text = "Выбрать приметив";
            this.selectedPrm.UseVisualStyleBackColor = true;
            // 
            // rbPolygon
            // 
            this.rbPolygon.AutoSize = true;
            this.rbPolygon.Location = new System.Drawing.Point(40, 108);
            this.rbPolygon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbPolygon.Name = "rbPolygon";
            this.rbPolygon.Size = new System.Drawing.Size(183, 21);
            this.rbPolygon.TabIndex = 2;
            this.rbPolygon.TabStop = true;
            this.rbPolygon.Text = "Создать многоугольник";
            this.rbPolygon.UseVisualStyleBackColor = true;
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Location = new System.Drawing.Point(40, 80);
            this.rbLine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(140, 21);
            this.rbLine.TabIndex = 1;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Создать отрезок";
            this.rbLine.UseVisualStyleBackColor = true;
            // 
            // rbPoint
            // 
            this.rbPoint.AutoSize = true;
            this.rbPoint.Location = new System.Drawing.Point(40, 52);
            this.rbPoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbPoint.Name = "rbPoint";
            this.rbPoint.Size = new System.Drawing.Size(124, 21);
            this.rbPoint.TabIndex = 0;
            this.rbPoint.TabStop = true;
            this.rbPoint.Text = "Создать точку";
            this.rbPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbPoint.UseVisualStyleBackColor = true;
            // 
            // button_create_new_polygon
            // 
            this.button_create_new_polygon.Location = new System.Drawing.Point(16, 215);
            this.button_create_new_polygon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_create_new_polygon.Name = "button_create_new_polygon";
            this.button_create_new_polygon.Size = new System.Drawing.Size(267, 28);
            this.button_create_new_polygon.TabIndex = 2;
            this.button_create_new_polygon.Text = "Создать новый многоугольник";
            this.button_create_new_polygon.UseVisualStyleBackColor = true;
            this.button_create_new_polygon.Click += new System.EventHandler(this.button_create_new_polygon_Click);
            // 
            // button_find_crossing_lines
            // 
            this.button_find_crossing_lines.Location = new System.Drawing.Point(16, 251);
            this.button_find_crossing_lines.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_find_crossing_lines.Name = "button_find_crossing_lines";
            this.button_find_crossing_lines.Size = new System.Drawing.Size(267, 28);
            this.button_find_crossing_lines.TabIndex = 3;
            this.button_find_crossing_lines.Text = "Найти пересечение двух ребер";
            this.button_find_crossing_lines.UseVisualStyleBackColor = true;
            this.button_find_crossing_lines.Click += new System.EventHandler(this.button_find_crossing_lines_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_distance_from_line_to_point);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.afin_submit);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(16, 303);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(267, 357);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Афинные преобразования";
            // 
            // button_distance_from_line_to_point
            // 
            this.button_distance_from_line_to_point.Location = new System.Drawing.Point(143, 298);
            this.button_distance_from_line_to_point.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_distance_from_line_to_point.Name = "button_distance_from_line_to_point";
            this.button_distance_from_line_to_point.Size = new System.Drawing.Size(116, 52);
            this.button_distance_from_line_to_point.TabIndex = 6;
            this.button_distance_from_line_to_point.Text = "Точка от отрезка";
            this.button_distance_from_line_to_point.UseVisualStyleBackColor = true;
            this.button_distance_from_line_to_point.Click += new System.EventHandler(this.button_distance_from_line_to_point_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.rotate_input);
            this.groupBox5.Location = new System.Drawing.Point(8, 220);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox5.Size = new System.Drawing.Size(251, 69);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Поворот (в градусах)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "α";
            // 
            // rotate_input
            // 
            this.rotate_input.Location = new System.Drawing.Point(32, 28);
            this.rotate_input.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rotate_input.Name = "rotate_input";
            this.rotate_input.Size = new System.Drawing.Size(52, 22);
            this.rotate_input.TabIndex = 0;
            this.rotate_input.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.scale_y_input);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.scale_x_input);
            this.groupBox4.Location = new System.Drawing.Point(8, 126);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox4.Size = new System.Drawing.Size(251, 69);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Маштабирование";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "y";
            // 
            // scale_y_input
            // 
            this.scale_y_input.Location = new System.Drawing.Point(135, 28);
            this.scale_y_input.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.scale_y_input.Name = "scale_y_input";
            this.scale_y_input.Size = new System.Drawing.Size(52, 22);
            this.scale_y_input.TabIndex = 2;
            this.scale_y_input.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "x";
            // 
            // scale_x_input
            // 
            this.scale_x_input.Location = new System.Drawing.Point(32, 28);
            this.scale_x_input.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.scale_x_input.Name = "scale_x_input";
            this.scale_x_input.Size = new System.Drawing.Size(52, 22);
            this.scale_x_input.TabIndex = 0;
            this.scale_x_input.Text = "1";
            // 
            // afin_submit
            // 
            this.afin_submit.Location = new System.Drawing.Point(8, 298);
            this.afin_submit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.afin_submit.Name = "afin_submit";
            this.afin_submit.Size = new System.Drawing.Size(127, 52);
            this.afin_submit.TabIndex = 1;
            this.afin_submit.Text = "Применить";
            this.afin_submit.UseVisualStyleBackColor = true;
            this.afin_submit.Click += new System.EventHandler(this.afin_submit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.move_y_input);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.move_x_input);
            this.groupBox3.Location = new System.Drawing.Point(11, 31);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox3.Size = new System.Drawing.Size(335, 85);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Перемещение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "y";
            // 
            // move_y_input
            // 
            this.move_y_input.Location = new System.Drawing.Point(180, 34);
            this.move_y_input.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.move_y_input.Name = "move_y_input";
            this.move_y_input.Size = new System.Drawing.Size(68, 22);
            this.move_y_input.TabIndex = 2;
            this.move_y_input.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "x";
            // 
            // move_x_input
            // 
            this.move_x_input.Location = new System.Drawing.Point(32, 28);
            this.move_x_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.move_x_input.Name = "move_x_input";
            this.move_x_input.Size = new System.Drawing.Size(52, 22);
            this.move_x_input.TabIndex = 0;
            this.move_x_input.Text = "0";
            // 
            // button_point_in_plg
            // 
            this.button_point_in_plg.Location = new System.Drawing.Point(24, 667);
            this.button_point_in_plg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_point_in_plg.Name = "button_point_in_plg";
            this.button_point_in_plg.Size = new System.Drawing.Size(251, 58);
            this.button_point_in_plg.TabIndex = 5;
            this.button_point_in_plg.Text = "Точка внутри многоугольника?";
            this.button_point_in_plg.UseVisualStyleBackColor = true;
            this.button_point_in_plg.Click += new System.EventHandler(this.button_point_in_plg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 756);
            this.Controls.Add(this.button_point_in_plg);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_find_crossing_lines);
            this.Controls.Add(this.button_create_new_polygon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_clear_canvas);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox move_y_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox move_x_input;
        private System.Windows.Forms.Button afin_submit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox scale_y_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox scale_x_input;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rotate_input;
        private System.Windows.Forms.Button button_point_in_plg;
        private System.Windows.Forms.Button button_distance_from_line_to_point;
    }
}

