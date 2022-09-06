
namespace Simple_Face_Recognation_App
{
    partial class Form1
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
            this.picCapture = new System.Windows.Forms.PictureBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnDetectFaces = new System.Windows.Forms.Button();
            this.textPersonName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnRecognize = new System.Windows.Forms.Button();
            this.picDetected = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetected)).BeginInit();
            this.SuspendLayout();
            // 
            // picCapture
            // 
            this.picCapture.Location = new System.Drawing.Point(13, 13);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(581, 507);
            this.picCapture.TabIndex = 0;
            this.picCapture.TabStop = false;
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(615, 13);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(190, 44);
            this.btnCapture.TabIndex = 1;
            this.btnCapture.Text = "1. Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnDetectFaces
            // 
            this.btnDetectFaces.Location = new System.Drawing.Point(614, 64);
            this.btnDetectFaces.Name = "btnDetectFaces";
            this.btnDetectFaces.Size = new System.Drawing.Size(190, 44);
            this.btnDetectFaces.TabIndex = 2;
            this.btnDetectFaces.Text = "2. Detect Faces";
            this.btnDetectFaces.UseVisualStyleBackColor = true;
            this.btnDetectFaces.Click += new System.EventHandler(this.btnDetectFaces_Click);
            // 
            // textPersonName
            // 
            this.textPersonName.Location = new System.Drawing.Point(615, 257);
            this.textPersonName.Name = "textPersonName";
            this.textPersonName.Size = new System.Drawing.Size(190, 20);
            this.textPersonName.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(615, 378);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(190, 42);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "3. Add Person";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(615, 426);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(190, 44);
            this.btnTrain.TabIndex = 5;
            this.btnTrain.Text = "4. Train Images";
            this.btnTrain.UseVisualStyleBackColor = true;
            // 
            // btnRecognize
            // 
            this.btnRecognize.Location = new System.Drawing.Point(615, 476);
            this.btnRecognize.Name = "btnRecognize";
            this.btnRecognize.Size = new System.Drawing.Size(190, 44);
            this.btnRecognize.TabIndex = 6;
            this.btnRecognize.Text = "5. Recognize Persons";
            this.btnRecognize.UseVisualStyleBackColor = true;
            // 
            // picDetected
            // 
            this.picDetected.Location = new System.Drawing.Point(615, 115);
            this.picDetected.Name = "picDetected";
            this.picDetected.Size = new System.Drawing.Size(188, 136);
            this.picDetected.TabIndex = 7;
            this.picDetected.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(615, 284);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(615, 311);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(614, 338);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(189, 20);
            this.textBox3.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 615);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.picDetected);
            this.Controls.Add(this.btnRecognize);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textPersonName);
            this.Controls.Add(this.btnDetectFaces);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.picCapture);
            this.Name = "Form1";
            this.Text = "  ";
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCapture;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnDetectFaces;
        private System.Windows.Forms.TextBox textPersonName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnRecognize;
        private System.Windows.Forms.PictureBox picDetected;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

