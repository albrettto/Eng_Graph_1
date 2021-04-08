namespace Eng_Graph_1
{
    partial class LR1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LR1));
            this.Canvas = new System.Windows.Forms.Panel();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.btn_BezierCurve = new System.Windows.Forms.Button();
            this.Add_features = new System.Windows.Forms.Panel();
            this.trckbr_scale = new System.Windows.Forms.TrackBar();
            this.trckbar_change = new System.Windows.Forms.TrackBar();
            this.btn_ellipseSegment = new System.Windows.Forms.Button();
            this.btn_diagram = new System.Windows.Forms.Button();
            this.btn_polygon = new System.Windows.Forms.Button();
            this.btn_gradient = new System.Windows.Forms.Button();
            this.btn_arrayOfPoints = new System.Windows.Forms.Button();
            this.btn_uploadImage = new System.Windows.Forms.Button();
            this.btn_turn = new System.Windows.Forms.Button();
            this.btn_scale = new System.Windows.Forms.Button();
            this.btn_inversionColor = new System.Windows.Forms.Button();
            this.btn_watermark = new System.Windows.Forms.Button();
            this.btn_vector = new System.Windows.Forms.Button();
            this.btn_colorModel = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.Add_features.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckbr_scale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckbar_change)).BeginInit();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Canvas.Location = new System.Drawing.Point(499, 12);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(600, 600);
            this.Canvas.TabIndex = 1;
            // 
            // btn_line
            // 
            this.btn_line.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_line.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_line.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_line.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_line.Location = new System.Drawing.Point(12, 12);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(160, 40);
            this.btn_line.TabIndex = 2;
            this.btn_line.Text = "Линия";
            this.btn_line.UseVisualStyleBackColor = false;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_ellipse.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ellipse.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_ellipse.Location = new System.Drawing.Point(12, 58);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(160, 40);
            this.btn_ellipse.TabIndex = 3;
            this.btn_ellipse.Text = "Эллипс";
            this.btn_ellipse.UseVisualStyleBackColor = false;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            // 
            // btn_BezierCurve
            // 
            this.btn_BezierCurve.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_BezierCurve.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_BezierCurve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_BezierCurve.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_BezierCurve.Location = new System.Drawing.Point(12, 104);
            this.btn_BezierCurve.Name = "btn_BezierCurve";
            this.btn_BezierCurve.Size = new System.Drawing.Size(160, 40);
            this.btn_BezierCurve.TabIndex = 4;
            this.btn_BezierCurve.Text = "Кривая Безье";
            this.btn_BezierCurve.UseVisualStyleBackColor = false;
            this.btn_BezierCurve.Click += new System.EventHandler(this.btn_BezierCurve_Click);
            // 
            // Add_features
            // 
            this.Add_features.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Add_features.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Add_features.Controls.Add(this.txtBox);
            this.Add_features.Controls.Add(this.trckbr_scale);
            this.Add_features.Controls.Add(this.trckbar_change);
            this.Add_features.Cursor = System.Windows.Forms.Cursors.Default;
            this.Add_features.Location = new System.Drawing.Point(12, 403);
            this.Add_features.Name = "Add_features";
            this.Add_features.Size = new System.Drawing.Size(479, 209);
            this.Add_features.TabIndex = 5;
            this.Add_features.Visible = false;
            // 
            // trckbr_scale
            // 
            this.trckbr_scale.LargeChange = 1;
            this.trckbr_scale.Location = new System.Drawing.Point(3, 86);
            this.trckbr_scale.Minimum = 1;
            this.trckbr_scale.Name = "trckbr_scale";
            this.trckbr_scale.Size = new System.Drawing.Size(471, 56);
            this.trckbr_scale.TabIndex = 1;
            this.trckbr_scale.Value = 1;
            this.trckbr_scale.Scroll += new System.EventHandler(this.trckbr_scale_Scroll);
            // 
            // trckbar_change
            // 
            this.trckbar_change.LargeChange = 1;
            this.trckbar_change.Location = new System.Drawing.Point(3, 148);
            this.trckbar_change.Maximum = 100;
            this.trckbar_change.Name = "trckbar_change";
            this.trckbar_change.Size = new System.Drawing.Size(471, 56);
            this.trckbar_change.TabIndex = 0;
            this.trckbar_change.Scroll += new System.EventHandler(this.trckbar_change_Scroll);
            // 
            // btn_ellipseSegment
            // 
            this.btn_ellipseSegment.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_ellipseSegment.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_ellipseSegment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ellipseSegment.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_ellipseSegment.Location = new System.Drawing.Point(12, 150);
            this.btn_ellipseSegment.Name = "btn_ellipseSegment";
            this.btn_ellipseSegment.Size = new System.Drawing.Size(160, 40);
            this.btn_ellipseSegment.TabIndex = 6;
            this.btn_ellipseSegment.Text = "Сегмент Эллипса";
            this.btn_ellipseSegment.UseVisualStyleBackColor = false;
            this.btn_ellipseSegment.Click += new System.EventHandler(this.btn_ellipseSegment_Click);
            // 
            // btn_diagram
            // 
            this.btn_diagram.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_diagram.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_diagram.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_diagram.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_diagram.Location = new System.Drawing.Point(12, 196);
            this.btn_diagram.Name = "btn_diagram";
            this.btn_diagram.Size = new System.Drawing.Size(160, 40);
            this.btn_diagram.TabIndex = 7;
            this.btn_diagram.Text = "Диаграмма";
            this.btn_diagram.UseVisualStyleBackColor = false;
            this.btn_diagram.Click += new System.EventHandler(this.btn_diagram_Click);
            // 
            // btn_polygon
            // 
            this.btn_polygon.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_polygon.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_polygon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_polygon.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_polygon.Location = new System.Drawing.Point(12, 242);
            this.btn_polygon.Name = "btn_polygon";
            this.btn_polygon.Size = new System.Drawing.Size(160, 40);
            this.btn_polygon.TabIndex = 8;
            this.btn_polygon.Text = "Полигон";
            this.btn_polygon.UseVisualStyleBackColor = false;
            this.btn_polygon.Click += new System.EventHandler(this.btn_polygon_Click);
            // 
            // btn_gradient
            // 
            this.btn_gradient.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_gradient.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_gradient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_gradient.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_gradient.Location = new System.Drawing.Point(12, 288);
            this.btn_gradient.Name = "btn_gradient";
            this.btn_gradient.Size = new System.Drawing.Size(160, 40);
            this.btn_gradient.TabIndex = 9;
            this.btn_gradient.Text = "Градиент";
            this.btn_gradient.UseVisualStyleBackColor = false;
            this.btn_gradient.Click += new System.EventHandler(this.btn_gradient_Click);
            // 
            // btn_arrayOfPoints
            // 
            this.btn_arrayOfPoints.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_arrayOfPoints.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_arrayOfPoints.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_arrayOfPoints.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_arrayOfPoints.Location = new System.Drawing.Point(12, 334);
            this.btn_arrayOfPoints.Name = "btn_arrayOfPoints";
            this.btn_arrayOfPoints.Size = new System.Drawing.Size(160, 40);
            this.btn_arrayOfPoints.TabIndex = 10;
            this.btn_arrayOfPoints.Text = "Массив точек";
            this.btn_arrayOfPoints.UseVisualStyleBackColor = false;
            this.btn_arrayOfPoints.Click += new System.EventHandler(this.btn_arrayOfPoints_Click);
            // 
            // btn_uploadImage
            // 
            this.btn_uploadImage.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_uploadImage.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_uploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_uploadImage.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_uploadImage.Location = new System.Drawing.Point(178, 12);
            this.btn_uploadImage.Name = "btn_uploadImage";
            this.btn_uploadImage.Size = new System.Drawing.Size(160, 40);
            this.btn_uploadImage.TabIndex = 11;
            this.btn_uploadImage.Text = "Загрузка картинки";
            this.btn_uploadImage.UseVisualStyleBackColor = false;
            this.btn_uploadImage.Click += new System.EventHandler(this.btn_uploadImage_Click);
            // 
            // btn_turn
            // 
            this.btn_turn.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_turn.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_turn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_turn.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_turn.Location = new System.Drawing.Point(178, 58);
            this.btn_turn.Name = "btn_turn";
            this.btn_turn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_turn.Size = new System.Drawing.Size(160, 40);
            this.btn_turn.TabIndex = 12;
            this.btn_turn.Text = "Поворот";
            this.btn_turn.UseVisualStyleBackColor = false;
            this.btn_turn.Click += new System.EventHandler(this.btn_turn_Click);
            // 
            // btn_scale
            // 
            this.btn_scale.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_scale.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_scale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_scale.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_scale.Location = new System.Drawing.Point(178, 104);
            this.btn_scale.Name = "btn_scale";
            this.btn_scale.Size = new System.Drawing.Size(160, 40);
            this.btn_scale.TabIndex = 13;
            this.btn_scale.Text = "Масштаб";
            this.btn_scale.UseVisualStyleBackColor = false;
            this.btn_scale.Click += new System.EventHandler(this.btn_scale_Click);
            // 
            // btn_inversionColor
            // 
            this.btn_inversionColor.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_inversionColor.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_inversionColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_inversionColor.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_inversionColor.Location = new System.Drawing.Point(178, 150);
            this.btn_inversionColor.Name = "btn_inversionColor";
            this.btn_inversionColor.Size = new System.Drawing.Size(160, 40);
            this.btn_inversionColor.TabIndex = 14;
            this.btn_inversionColor.Text = "Инверсия цвета";
            this.btn_inversionColor.UseVisualStyleBackColor = false;
            this.btn_inversionColor.Click += new System.EventHandler(this.btn_inversionColor_Click);
            // 
            // btn_watermark
            // 
            this.btn_watermark.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_watermark.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_watermark.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_watermark.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_watermark.Location = new System.Drawing.Point(178, 196);
            this.btn_watermark.Name = "btn_watermark";
            this.btn_watermark.Size = new System.Drawing.Size(160, 40);
            this.btn_watermark.TabIndex = 15;
            this.btn_watermark.Text = "Водяной знак";
            this.btn_watermark.UseVisualStyleBackColor = false;
            this.btn_watermark.Click += new System.EventHandler(this.btn_watermark_Click);
            // 
            // btn_vector
            // 
            this.btn_vector.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_vector.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_vector.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_vector.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_vector.Location = new System.Drawing.Point(178, 242);
            this.btn_vector.Name = "btn_vector";
            this.btn_vector.Size = new System.Drawing.Size(160, 40);
            this.btn_vector.TabIndex = 16;
            this.btn_vector.Text = "Векторное изобр-ие";
            this.btn_vector.UseVisualStyleBackColor = false;
            this.btn_vector.Click += new System.EventHandler(this.btn_vector_Click);
            // 
            // btn_colorModel
            // 
            this.btn_colorModel.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_colorModel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_colorModel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_colorModel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_colorModel.Location = new System.Drawing.Point(178, 288);
            this.btn_colorModel.Name = "btn_colorModel";
            this.btn_colorModel.Size = new System.Drawing.Size(160, 40);
            this.btn_colorModel.TabIndex = 17;
            this.btn_colorModel.Text = "Цветовая модель";
            this.btn_colorModel.UseVisualStyleBackColor = false;
            this.btn_colorModel.Click += new System.EventHandler(this.btn_colorModel_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(4, 37);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(470, 22);
            this.txtBox.TabIndex = 2;
            this.txtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // LR1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1105, 621);
            this.Controls.Add(this.btn_colorModel);
            this.Controls.Add(this.btn_vector);
            this.Controls.Add(this.btn_watermark);
            this.Controls.Add(this.btn_inversionColor);
            this.Controls.Add(this.btn_scale);
            this.Controls.Add(this.btn_turn);
            this.Controls.Add(this.btn_uploadImage);
            this.Controls.Add(this.btn_arrayOfPoints);
            this.Controls.Add(this.btn_gradient);
            this.Controls.Add(this.btn_polygon);
            this.Controls.Add(this.btn_diagram);
            this.Controls.Add(this.btn_ellipseSegment);
            this.Controls.Add(this.Add_features);
            this.Controls.Add(this.btn_BezierCurve);
            this.Controls.Add(this.btn_ellipse);
            this.Controls.Add(this.btn_line);
            this.Controls.Add(this.Canvas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LR1";
            this.Text = "Лабораторная работа 1";
            this.Add_features.ResumeLayout(false);
            this.Add_features.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckbr_scale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckbar_change)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.Button btn_BezierCurve;
        private System.Windows.Forms.Panel Add_features;
        private System.Windows.Forms.Button btn_ellipseSegment;
        private System.Windows.Forms.Button btn_diagram;
        private System.Windows.Forms.Button btn_polygon;
        private System.Windows.Forms.Button btn_gradient;
        private System.Windows.Forms.Button btn_arrayOfPoints;
        private System.Windows.Forms.Button btn_uploadImage;
        private System.Windows.Forms.Button btn_turn;
        private System.Windows.Forms.Button btn_scale;
        private System.Windows.Forms.Button btn_inversionColor;
        private System.Windows.Forms.Button btn_watermark;
        private System.Windows.Forms.Button btn_vector;
        private System.Windows.Forms.Button btn_colorModel;
        private System.Windows.Forms.TrackBar trckbar_change;
        private System.Windows.Forms.TrackBar trckbr_scale;
        private System.Windows.Forms.TextBox txtBox;
    }
}

