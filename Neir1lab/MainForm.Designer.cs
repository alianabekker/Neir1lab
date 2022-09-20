namespace Neir1lab
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnDrawA = new System.Windows.Forms.Button();
            this.btnDrawB = new System.Windows.Forms.Button();
            this.dataA = new System.Windows.Forms.DataGridView();
            this.alpha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.low = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.high = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataB = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataC = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.graphics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.comparison = new System.Windows.Forms.Button();
            this.more = new System.Windows.Forms.Button();
            this.lessORequal = new System.Windows.Forms.Button();
            this.moreORequal = new System.Windows.Forms.Button();
            this.less = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.notEqual = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphics)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDrawA
            // 
            this.btnDrawA.Location = new System.Drawing.Point(79, 577);
            this.btnDrawA.Name = "btnDrawA";
            this.btnDrawA.Size = new System.Drawing.Size(107, 29);
            this.btnDrawA.TabIndex = 4;
            this.btnDrawA.Text = "Построить А";
            this.btnDrawA.UseVisualStyleBackColor = true;
            this.btnDrawA.Click += new System.EventHandler(this.btnDrawA_Click);
            // 
            // btnDrawB
            // 
            this.btnDrawB.Location = new System.Drawing.Point(350, 579);
            this.btnDrawB.Name = "btnDrawB";
            this.btnDrawB.Size = new System.Drawing.Size(107, 27);
            this.btnDrawB.TabIndex = 5;
            this.btnDrawB.Text = "Построить В";
            this.btnDrawB.UseVisualStyleBackColor = true;
            this.btnDrawB.Click += new System.EventHandler(this.btnDrawB_Click);
            // 
            // dataA
            // 
            this.dataA.AllowUserToResizeRows = false;
            this.dataA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alpha,
            this.low,
            this.high});
            this.dataA.Location = new System.Drawing.Point(49, 421);
            this.dataA.Name = "dataA";
            this.dataA.RowHeadersVisible = false;
            this.dataA.RowHeadersWidth = 51;
            this.dataA.RowTemplate.Height = 24;
            this.dataA.Size = new System.Drawing.Size(256, 150);
            this.dataA.TabIndex = 7;
            this.dataA.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataA_MouseDoubleClick);
            // 
            // alpha
            // 
            dataGridViewCellStyle55.Format = "N2";
            dataGridViewCellStyle55.NullValue = null;
            this.alpha.DefaultCellStyle = dataGridViewCellStyle55;
            this.alpha.HeaderText = "a lvl";
            this.alpha.MinimumWidth = 6;
            this.alpha.Name = "alpha";
            this.alpha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.alpha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.alpha.Width = 50;
            // 
            // low
            // 
            dataGridViewCellStyle56.Format = "N2";
            dataGridViewCellStyle56.NullValue = null;
            this.low.DefaultCellStyle = dataGridViewCellStyle56;
            this.low.HeaderText = "нижняя";
            this.low.MinimumWidth = 6;
            this.low.Name = "low";
            this.low.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.low.Width = 70;
            // 
            // high
            // 
            dataGridViewCellStyle57.Format = "N2";
            dataGridViewCellStyle57.NullValue = null;
            this.high.DefaultCellStyle = dataGridViewCellStyle57;
            this.high.HeaderText = "верхняя";
            this.high.MinimumWidth = 6;
            this.high.Name = "high";
            this.high.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.high.Width = 70;
            // 
            // dataB
            // 
            this.dataB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataB.Location = new System.Drawing.Point(330, 421);
            this.dataB.Name = "dataB";
            this.dataB.RowHeadersVisible = false;
            this.dataB.RowHeadersWidth = 51;
            this.dataB.RowTemplate.Height = 24;
            this.dataB.Size = new System.Drawing.Size(256, 150);
            this.dataB.TabIndex = 8;
            this.dataB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataB_MouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle58.Format = "N2";
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle58;
            this.dataGridViewTextBoxColumn1.HeaderText = "a lvl";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle59.Format = "N2";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle59;
            this.dataGridViewTextBoxColumn2.HeaderText = "нижняя";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle60.Format = "N2";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle60;
            this.dataGridViewTextBoxColumn3.HeaderText = "верхняя";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Множество А";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Множество B";
            // 
            // dataC
            // 
            this.dataC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataC.Location = new System.Drawing.Point(707, 49);
            this.dataC.Name = "dataC";
            this.dataC.RowHeadersVisible = false;
            this.dataC.RowHeadersWidth = 51;
            this.dataC.RowTemplate.Height = 24;
            this.dataC.Size = new System.Drawing.Size(256, 150);
            this.dataC.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle61.Format = "N2";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle61;
            this.dataGridViewTextBoxColumn4.HeaderText = "a lvl";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle62.Format = "N2";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle62;
            this.dataGridViewTextBoxColumn5.HeaderText = "нижняя";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewCellStyle63.Format = "N2";
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle63;
            this.dataGridViewTextBoxColumn6.HeaderText = "верхняя";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(786, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Множество C";
            // 
            // graphics
            // 
            chartArea7.Name = "ChartArea1";
            this.graphics.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.graphics.Legends.Add(legend7);
            this.graphics.Location = new System.Drawing.Point(49, 12);
            this.graphics.Name = "graphics";
            series19.BorderWidth = 3;
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series19.Legend = "Legend1";
            series19.Name = "множество А";
            series20.BorderWidth = 3;
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series20.Legend = "Legend1";
            series20.Name = "множество В";
            series21.BorderWidth = 3;
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series21.Legend = "Legend1";
            series21.Name = "множество С";
            this.graphics.Series.Add(series19);
            this.graphics.Series.Add(series20);
            this.graphics.Series.Add(series21);
            this.graphics.Size = new System.Drawing.Size(632, 363);
            this.graphics.TabIndex = 0;
            this.graphics.Text = "chart1";
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSum.Location = new System.Drawing.Point(758, 225);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(55, 46);
            this.btnSum.TabIndex = 13;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSubtraction.Location = new System.Drawing.Point(839, 225);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(55, 46);
            this.btnSubtraction.TabIndex = 14;
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = true;
            this.btnSubtraction.Click += new System.EventHandler(this.btnSubtraction_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMultiply.Location = new System.Drawing.Point(758, 293);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(55, 46);
            this.btnMultiply.TabIndex = 15;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDivision.Location = new System.Drawing.Point(839, 293);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(55, 46);
            this.btnDivision.TabIndex = 16;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // comparison
            // 
            this.comparison.Location = new System.Drawing.Point(758, 372);
            this.comparison.Name = "comparison";
            this.comparison.Size = new System.Drawing.Size(144, 47);
            this.comparison.TabIndex = 17;
            this.comparison.Text = "Сравнить";
            this.comparison.UseVisualStyleBackColor = true;
            this.comparison.Click += new System.EventHandler(this.comparison_Click);
            // 
            // more
            // 
            this.more.Enabled = false;
            this.more.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.more.Location = new System.Drawing.Point(707, 439);
            this.more.Name = "more";
            this.more.Size = new System.Drawing.Size(68, 46);
            this.more.TabIndex = 18;
            this.more.Text = ">";
            this.more.UseVisualStyleBackColor = true;
            // 
            // lessORequal
            // 
            this.lessORequal.Enabled = false;
            this.lessORequal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lessORequal.Location = new System.Drawing.Point(789, 491);
            this.lessORequal.Name = "lessORequal";
            this.lessORequal.Size = new System.Drawing.Size(73, 46);
            this.lessORequal.TabIndex = 19;
            this.lessORequal.Text = "<=";
            this.lessORequal.UseVisualStyleBackColor = true;
            // 
            // moreORequal
            // 
            this.moreORequal.Enabled = false;
            this.moreORequal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moreORequal.Location = new System.Drawing.Point(707, 491);
            this.moreORequal.Name = "moreORequal";
            this.moreORequal.Size = new System.Drawing.Size(68, 46);
            this.moreORequal.TabIndex = 20;
            this.moreORequal.Text = ">=";
            this.moreORequal.UseVisualStyleBackColor = true;
            // 
            // less
            // 
            this.less.Enabled = false;
            this.less.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.less.Location = new System.Drawing.Point(789, 439);
            this.less.Name = "less";
            this.less.Size = new System.Drawing.Size(73, 46);
            this.less.TabIndex = 21;
            this.less.Text = "<";
            this.less.UseVisualStyleBackColor = true;
            // 
            // equal
            // 
            this.equal.Enabled = false;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equal.Location = new System.Drawing.Point(878, 439);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(69, 46);
            this.equal.TabIndex = 23;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            // 
            // notEqual
            // 
            this.notEqual.Enabled = false;
            this.notEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notEqual.Location = new System.Drawing.Point(878, 491);
            this.notEqual.Name = "notEqual";
            this.notEqual.Size = new System.Drawing.Size(69, 46);
            this.notEqual.TabIndex = 22;
            this.notEqual.Text = "/=";
            this.notEqual.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 618);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.notEqual);
            this.Controls.Add(this.less);
            this.Controls.Add(this.moreORequal);
            this.Controls.Add(this.lessORequal);
            this.Controls.Add(this.more);
            this.Controls.Add(this.comparison);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtraction);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.graphics);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataA);
            this.Controls.Add(this.btnDrawB);
            this.Controls.Add(this.btnDrawA);
            this.Controls.Add(this.dataB);
            this.Controls.Add(this.dataC);
            this.Name = "MainForm";
            this.Text = "Lab1";
            ((System.ComponentModel.ISupportInitialize)(this.dataA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDrawA;
        private System.Windows.Forms.Button btnDrawB;
        private System.Windows.Forms.DataGridView dataA;
        private System.Windows.Forms.DataGridView dataB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart graphics;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn alpha;
        private System.Windows.Forms.DataGridViewTextBoxColumn low;
        private System.Windows.Forms.DataGridViewTextBoxColumn high;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button comparison;
        private System.Windows.Forms.Button more;
        private System.Windows.Forms.Button lessORequal;
        private System.Windows.Forms.Button moreORequal;
        private System.Windows.Forms.Button less;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button notEqual;
    }
}

