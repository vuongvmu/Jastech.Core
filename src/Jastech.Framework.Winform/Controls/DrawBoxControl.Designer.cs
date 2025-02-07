﻿namespace Jastech.Framework.Winform.Controls
{
    partial class DrawBoxControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlText = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.lblGrayLevel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteFigure = new System.Windows.Forms.Button();
            this.btnFitZoom = new System.Windows.Forms.Button();
            this.btnDrawLine = new System.Windows.Forms.Button();
            this.btnDrawNone = new System.Windows.Forms.Button();
            this.btnPanning = new System.Windows.Forms.Button();
            this.ctxDisplayMode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuPointerMode = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPanningMode = new System.Windows.Forms.ToolStripMenuItem();
            this.menuROIMode = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFitZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveImage = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGrayPoint = new System.Windows.Forms.Label();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlText.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlDisplay.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)(this.pbxDisplay)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.ctxDisplayMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(695, 484);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnlText, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlDisplay, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(40, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(655, 484);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pnlText
            // 
            this.pnlText.Controls.Add(this.tableLayoutPanel2);
            this.pnlText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlText.Location = new System.Drawing.Point(0, 454);
            this.pnlText.Margin = new System.Windows.Forms.Padding(0);
            this.pnlText.Name = "pnlText";
            this.pnlText.Size = new System.Drawing.Size(655, 30);
            this.pnlText.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblGrayPoint, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblGrayLevel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(655, 30);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(555, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gray :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplay.Location = new System.Drawing.Point(0, 0);
            this.pnlDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(655, 454);
            this.pnlDisplay.TabIndex = 2;
            // 
            // lblGrayLevel
            // 
            this.lblGrayLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGrayLevel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrayLevel.ForeColor = System.Drawing.Color.White;
            this.lblGrayLevel.Location = new System.Drawing.Point(605, 0);
            this.lblGrayLevel.Margin = new System.Windows.Forms.Padding(0);
            this.lblGrayLevel.Name = "lblGrayLevel";
            this.lblGrayLevel.Size = new System.Drawing.Size(50, 30);
            this.lblGrayLevel.TabIndex = 1;
            this.lblGrayLevel.Text = "255";
            this.lblGrayLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btnDeleteFigure, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.btnFitZoom, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.btnDrawLine, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.btnDrawNone, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnPanning, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 7;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(40, 484);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btnDeleteFigure
            // 
            this.btnDeleteFigure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnDeleteFigure.BackgroundImage = global::Jastech.Framework.Winform.Properties.Resources.Delete_White;
            this.btnDeleteFigure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteFigure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteFigure.Location = new System.Drawing.Point(0, 160);
            this.btnDeleteFigure.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteFigure.Name = "btnDeleteFigure";
            this.btnDeleteFigure.Size = new System.Drawing.Size(40, 40);
            this.btnDeleteFigure.TabIndex = 4;
            this.btnDeleteFigure.TabStop = false;
            this.btnDeleteFigure.UseVisualStyleBackColor = false;
            this.btnDeleteFigure.Click += new System.EventHandler(this.btnDeleteFigure_Click);
            // 
            // btnFitZoom
            // 
            this.btnFitZoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnFitZoom.BackgroundImage = global::Jastech.Framework.Winform.Properties.Resources.Fit_White;
            this.btnFitZoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFitZoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFitZoom.Location = new System.Drawing.Point(0, 120);
            this.btnFitZoom.Margin = new System.Windows.Forms.Padding(0);
            this.btnFitZoom.Name = "btnFitZoom";
            this.btnFitZoom.Size = new System.Drawing.Size(40, 40);
            this.btnFitZoom.TabIndex = 3;
            this.btnFitZoom.TabStop = false;
            this.btnFitZoom.UseVisualStyleBackColor = false;
            this.btnFitZoom.Click += new System.EventHandler(this.btnFitZoom_Click);
            // 
            // btnDrawLine
            // 
            this.btnDrawLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnDrawLine.BackgroundImage = global::Jastech.Framework.Winform.Properties.Resources.Line_arrow_White;
            this.btnDrawLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDrawLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDrawLine.Location = new System.Drawing.Point(0, 80);
            this.btnDrawLine.Margin = new System.Windows.Forms.Padding(0);
            this.btnDrawLine.Name = "btnDrawLine";
            this.btnDrawLine.Size = new System.Drawing.Size(40, 40);
            this.btnDrawLine.TabIndex = 2;
            this.btnDrawLine.TabStop = false;
            this.btnDrawLine.UseVisualStyleBackColor = false;
            this.btnDrawLine.Click += new System.EventHandler(this.btnDrawLine_Click);
            // 
            // btnDrawNone
            // 
            this.btnDrawNone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnDrawNone.BackgroundImage = global::Jastech.Framework.Winform.Properties.Resources.Pointer_White;
            this.btnDrawNone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDrawNone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDrawNone.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnDrawNone.Location = new System.Drawing.Point(0, 0);
            this.btnDrawNone.Margin = new System.Windows.Forms.Padding(0);
            this.btnDrawNone.Name = "btnDrawNone";
            this.btnDrawNone.Size = new System.Drawing.Size(40, 40);
            this.btnDrawNone.TabIndex = 1;
            this.btnDrawNone.TabStop = false;
            this.btnDrawNone.UseVisualStyleBackColor = false;
            this.btnDrawNone.Click += new System.EventHandler(this.btnDrawNone_Click);
            // 
            // btnPanning
            // 
            this.btnPanning.BackgroundImage = global::Jastech.Framework.Winform.Properties.Resources.Panning_White;
            this.btnPanning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPanning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPanning.Location = new System.Drawing.Point(0, 40);
            this.btnPanning.Margin = new System.Windows.Forms.Padding(0);
            this.btnPanning.Name = "btnPanning";
            this.btnPanning.Size = new System.Drawing.Size(40, 40);
            this.btnPanning.TabIndex = 3;
            this.btnPanning.TabStop = false;
            this.btnPanning.UseVisualStyleBackColor = false;
            this.btnPanning.Click += new System.EventHandler(this.btnPanning_Click);
            // 
            // ctxDisplayMode
            // 
            this.ctxDisplayMode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPointerMode,
            this.menuPanningMode,
            this.menuROIMode,
            this.menuFitZoom,
            this.menuSaveImage});
            this.ctxDisplayMode.Name = "contextMenuStrip";
            this.ctxDisplayMode.Size = new System.Drawing.Size(137, 114);
            this.ctxDisplayMode.Opening += new System.ComponentModel.CancelEventHandler(this.ctxDisplayMode_Opening);
            // 
            // menuPointerMode
            // 
            this.menuPointerMode.Name = "menuPointerMode";
            this.menuPointerMode.Size = new System.Drawing.Size(136, 22);
            this.menuPointerMode.Text = "Pointer";
            this.menuPointerMode.Click += new System.EventHandler(this.menuPointerMode_Click);
            // 
            // menuPanningMode
            // 
            this.menuPanningMode.Name = "menuPanningMode";
            this.menuPanningMode.Size = new System.Drawing.Size(136, 22);
            this.menuPanningMode.Text = "Panning";
            this.menuPanningMode.Click += new System.EventHandler(this.menuPanningMode_Click);
            // 
            // menuROIMode
            // 
            this.menuROIMode.Name = "menuROIMode";
            this.menuROIMode.Size = new System.Drawing.Size(136, 22);
            this.menuROIMode.Text = "ROI";
            this.menuROIMode.Click += new System.EventHandler(this.menuROIMode_Click);
            // 
            // menuFitZoom
            // 
            this.menuFitZoom.Name = "menuFitZoom";
            this.menuFitZoom.Size = new System.Drawing.Size(136, 22);
            this.menuFitZoom.Text = "FitZoom";
            this.menuFitZoom.Click += new System.EventHandler(this.menuFitZoom_Click);
            // 
            // menuSaveImage
            // 
            this.menuSaveImage.Name = "menuSaveImage";
            this.menuSaveImage.Size = new System.Drawing.Size(136, 22);
            this.menuSaveImage.Text = "Save Image";
            this.menuSaveImage.Click += new System.EventHandler(this.menuSaveImage_Click);
            // 
            // lblGrayPoint
            // 
            this.lblGrayPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGrayPoint.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrayPoint.ForeColor = System.Drawing.Color.White;
            this.lblGrayPoint.Location = new System.Drawing.Point(0, 0);
            this.lblGrayPoint.Margin = new System.Windows.Forms.Padding(0);
            this.lblGrayPoint.Name = "lblGrayPoint";
            this.lblGrayPoint.Size = new System.Drawing.Size(555, 30);
            this.lblGrayPoint.TabIndex = 1;
            this.lblGrayPoint.Text = "(0,0)";
            this.lblGrayPoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DrawBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ContextMenuStrip = this.ctxDisplayMode;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "DrawBoxControl";
            this.Size = new System.Drawing.Size(695, 484);
            this.Load += new System.EventHandler(this.DrawBoxControl_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlText.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlDisplay.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ctxDisplayMode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnlText;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnDrawNone;
        private System.Windows.Forms.Button btnDrawLine;
        private System.Windows.Forms.Button btnPanning;
        private System.Windows.Forms.ContextMenuStrip ctxDisplayMode;
        private System.Windows.Forms.ToolStripMenuItem menuPointerMode;
        private System.Windows.Forms.ToolStripMenuItem menuPanningMode;
        private System.Windows.Forms.ToolStripMenuItem menuROIMode;
        private System.Windows.Forms.Button btnFitZoom;
        private System.Windows.Forms.ToolStripMenuItem menuFitZoom;
        private System.Windows.Forms.Button btnDeleteFigure;
        private System.Windows.Forms.ToolStripMenuItem menuSaveImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGrayLevel;
        private System.Windows.Forms.Label lblGrayPoint;
    }
}
