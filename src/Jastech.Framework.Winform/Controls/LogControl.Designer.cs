﻿namespace Jastech.Framework.Winform.Controls
{
    partial class LogControl
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
            this.lstLogMessage = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstLogMessage
            // 
            this.lstLogMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLogMessage.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.lstLogMessage.FormattingEnabled = true;
            this.lstLogMessage.HorizontalScrollbar = true;
            this.lstLogMessage.ItemHeight = 15;
            this.lstLogMessage.Location = new System.Drawing.Point(0, 0);
            this.lstLogMessage.Margin = new System.Windows.Forms.Padding(0);
            this.lstLogMessage.Name = "lstLogMessage";
            this.lstLogMessage.Size = new System.Drawing.Size(300, 300);
            this.lstLogMessage.TabIndex = 1;
            // 
            // LogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lstLogMessage);
            this.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold);
            this.Name = "LogControl";
            this.Size = new System.Drawing.Size(300, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstLogMessage;
    }
}
