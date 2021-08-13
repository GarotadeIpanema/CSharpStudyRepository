
namespace kiosk
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.side = new System.Windows.Forms.Button();
            this.drinks = new System.Windows.Forms.Button();
            this.hanburger = new System.Windows.Forms.Button();
            this.added = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.counter = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.bill = new System.Windows.Forms.Button();
            this.today = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            // 
            // splitContainer3
            // 
            resources.ApplyResources(this.splitContainer3, "splitContainer3");
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.side);
            this.splitContainer3.Panel1.Controls.Add(this.drinks);
            this.splitContainer3.Panel1.Controls.Add(this.hanburger);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.added);
            // 
            // side
            // 
            resources.ApplyResources(this.side, "side");
            this.side.Name = "side";
            this.side.UseVisualStyleBackColor = true;
            this.side.Click += new System.EventHandler(this.side_Click);
            // 
            // drinks
            // 
            resources.ApplyResources(this.drinks, "drinks");
            this.drinks.Name = "drinks";
            this.drinks.UseVisualStyleBackColor = true;
            this.drinks.Click += new System.EventHandler(this.drinks_Click);
            // 
            // hanburger
            // 
            resources.ApplyResources(this.hanburger, "hanburger");
            this.hanburger.Name = "hanburger";
            this.hanburger.UseVisualStyleBackColor = true;
            this.hanburger.Click += new System.EventHandler(this.hanburger_Click);
            // 
            // added
            // 
            resources.ApplyResources(this.added, "added");
            this.added.Name = "added";
            this.added.ReadOnly = true;
            // 
            // splitContainer2
            // 
            resources.ApplyResources(this.splitContainer2, "splitContainer2");
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.today);
            this.splitContainer2.Panel2.Controls.Add(this.counter);
            this.splitContainer2.Panel2.Controls.Add(this.price);
            this.splitContainer2.Panel2.Controls.Add(this.reset);
            this.splitContainer2.Panel2.Controls.Add(this.bill);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // counter
            // 
            resources.ApplyResources(this.counter, "counter");
            this.counter.Name = "counter";
            // 
            // price
            // 
            resources.ApplyResources(this.price, "price");
            this.price.Name = "price";
            // 
            // reset
            // 
            resources.ApplyResources(this.reset, "reset");
            this.reset.Name = "reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // bill
            // 
            resources.ApplyResources(this.bill, "bill");
            this.bill.Name = "bill";
            this.bill.UseVisualStyleBackColor = true;
            this.bill.Click += new System.EventHandler(this.bill_Click);
            // 
            // today
            // 
            resources.ApplyResources(this.today, "today");
            this.today.Name = "today";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button side;
        private System.Windows.Forms.Button drinks;
        private System.Windows.Forms.Button hanburger;
        private System.Windows.Forms.TextBox added;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button bill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label today;
        private System.Windows.Forms.Timer timer1;
    }
}

