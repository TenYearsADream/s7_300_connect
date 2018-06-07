using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sharp7;


namespace sharp7_deneme_plc_connect
{
    public partial class Form1 : Form
    {
        private S7Client client;
        private int Result;
        





        public Form1()
        {
            InitializeComponent();
            client = new S7Client();
        }

        private void ShowResult(int Result)
        {
            label_ip_and_err.Text = client.ErrorText(Result);
            label_ip_and_err.BackColor = Color.Yellow;
        }

        private void button_connect_Click(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            
            {

                int Result;
                int Status = 0;
                Result = client.ConnectTo(textBox_ip_add.Text, 0, 2);
                Status = client.PlcGetStatus(ref Status);
                ShowResult(Result);
                if (Result==0)
                {
                    label_ip_and_err.Text = "CONNECTED";
                    label_ip_and_err.BackColor = Color.Green;
                    toolStripStatusLabel1.Text = "";
                    textBox_ip_add.Enabled = false;
                    button_connect.Enabled = false;
                    button_disconnect.Enabled = true;
                    button_new_ref.Enabled = true;
                    start_m1_pb.Enabled = true;
                    start_m2_pb.Enabled = true;
                    start_m3_pb.Enabled = true;
                    stop_m1_pb.Enabled = true;
                    stop_m2_pb.Enabled = true;
                    stop_m3_pb.Enabled = true;

                }
                else
                {
                    
                    label_ip_and_err.Text = (client.ErrorText(Result));
                }
                if (Status == 0)
                {
                    label_status1.Text = " UNKNOWN";
                    label_status1.BackColor = Color.Gray;
                }
                else if (Status == 4)
                {
                    label_status1.Text =  " STOP";
                    label_status1.BackColor = Color.Red;
                }
                else if (Status==8)
                {
                    label_status1.Text = " RUN";
                    label_status1.BackColor = Color.Green;
                }
                else
                {
                    label_status1.Text = " ERROR";
                    label_status1.BackColor = Color.Yellow;
                }
                           
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            byte[] db1Buffer = new byte[58];                    ///db1 dbsinin okunacak alaninin buffer adresi isaretleniyor 
            Result = client.DBRead(1, 0,58, db1Buffer);         ///db1 dbsinin tum bytlari okunuyor 58 adet byte var db1 de
            if (Result != 0)                                    ///sonuc sifirsa hata mesaji ver degilse devam et
            {

               
                toolStripStatusLabel1.Text= client.ErrorText(Result);

            }
            double db1_dbd18 = S7.GetRealAt(db1Buffer, 18);     ///db1 dbsinin buffer a alinmis 58 byte icerisinde 18. real olan bayti oku ve double degiskene ata
            textBox_act_ref.Text = db1_dbd18.ToString("0.##");  /// double degiskeni (db1_dbd18) string degere donustur ve textbox a yaz
            progressBar_press.Value =Convert.ToInt32(db1_dbd18) ;



            double db1_dbd14 = S7.GetRealAt(db1Buffer, 14);
            textBox_temp.Text = db1_dbd14.ToString("0.##");
            progressBar_temp.Value = Convert.ToInt32(db1_dbd14);


            bool motor1_state ,motor2_state, motor3_state;
            
            motor1_state = S7.GetBitAt(db1Buffer, 54, 3);
            motor2_state = S7.GetBitAt(db1Buffer, 54, 4);
            motor3_state = S7.GetBitAt(db1Buffer, 54, 5);
            if (motor1_state == true)
            {m1_state.BackColor = Color.Green;}
            else{m1_state.BackColor = Color.Red;}
            if (motor2_state == true)
            {m2_state.BackColor = Color.Green;}
            else{m2_state.BackColor = Color.Red;}
            if (motor3_state == true)
            {m3_state.BackColor = Color.Green;}
            else{m3_state.BackColor = Color.Red;}


      }



        //bool str_m1=true;
        //bool stp_m1 = false;


        //byte[] db1buffer = new byte[9];
        //const int start_index = 54;

        // S7.SetBitAt(ref db1buffer, 54 - start_index, 0, false);
        //  Result = client.DBWrite(1, start_index, db1buffer.Length, db1buffer);


        //   if (Result != 0)
        //   {
        //       textBox_set_ref.Text = client.ErrorText(Result);
        //   }

        private void start_m1_pb_MouseDown(object sender, MouseEventArgs e)

        {
          
            Byte[] db1buffer = new byte[1];
            const int start_index = 54;
            S7.SetBitAt(ref db1buffer, 54 - start_index, 0, true);
            
            Result = client.DBWrite(1, start_index, db1buffer.Length, db1buffer);
            if (Result != 0)
           {
               
                toolStripStatusLabel1.Text = client.ErrorText(Result);
            }

        }
        private void stop_m1_pb_Click(object sender, EventArgs e)
        {
           
            byte[] db1buffer = new byte[1];
            const int start_index = 54;
            
            S7.SetBitAt(ref db1buffer, 54 - start_index, 6, true);
            Result = client.DBWrite(1, start_index, db1buffer.Length, db1buffer);
            if (Result != 0)
            {
                toolStripStatusLabel1.Text = client.ErrorText(Result);
            }
        }
        private void start_m2_pb_MouseDown(object sender, MouseEventArgs e)
        {
           
            byte[] db1buffer = new byte[1];
            const int start_index = 54;
            S7.SetBitAt(ref db1buffer, 54 - start_index, 1, true);
            Result = client.DBWrite(1, start_index, db1buffer.Length, db1buffer);
            if (Result != 0)
            {
                toolStripStatusLabel1.Text = client.ErrorText(Result);
            }

        }

        private void stop_m2_pb_Click(object sender, EventArgs e)
        {

   
            byte[] db1buffer = new byte[1];
            const int start_index = 54;
            S7.SetBitAt(ref db1buffer, 54 - start_index, 7, true);
            Result = client.DBWrite(1, start_index, db1buffer.Length, db1buffer);
            if (Result != 0)
            {
                toolStripStatusLabel1.Text = client.ErrorText(Result);
            }
        }











        private void button_new_ref_Click(object sender, EventArgs e)
           
        {
            float val;
            val = Convert.ToSingle(textBox_set_ref.Text);       //textbox icindeki degeri gonderebilmek icin ilk once float veriye ceviriyoruz
            byte[] db1Buffer = new byte[4];                     //burasi cok onemli, yazicagimiz db adresinin max. kac byte veri tutabilecegi belirtiliyor
            const int START_INDEX = 38;                         //db1 icindeki 38. byte yani db1.dbd38
            S7.SetRealAt(db1Buffer, 38 - START_INDEX,  val);    //ve burada deger gonderiliyor eger sorun varsa textbox icine hata kodunu donduruyor
            Result = client.DBWrite(1, START_INDEX, db1Buffer.Length, db1Buffer);
            if (Result != 0)
            {
                toolStripStatusLabel1.Text = client.ErrorText(Result);
            }
            
        }



      



        private void button_disconnect_Click(object sender, EventArgs e)
        {
            
            client.Disconnect();
            label_ip_and_err.Text = "DISCONNECTED";
            label_ip_and_err.BackColor = Color.Red;
            label_status1.Text = label_status1.Text;
            label_status1.BackColor = Color.Red;
            
            textBox_ip_add.Enabled = true;
            button_connect.Enabled = true;
            button_disconnect.Enabled = false;
            button_new_ref.Enabled = false;
            start_m1_pb.Enabled = false;
            start_m2_pb.Enabled = false;
            start_m3_pb.Enabled = false;
            stop_m1_pb.Enabled = false;
            stop_m2_pb.Enabled = false;
            stop_m3_pb.Enabled = false;
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            textBox_set_ref.Text = textBox_set_ref.Text + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_set_ref.Text = textBox_set_ref.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_set_ref.Text = textBox_set_ref.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox_set_ref.Text = textBox_set_ref.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_set_ref.Text = textBox_set_ref.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_set_ref.Text = textBox_set_ref.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox_set_ref.Text = textBox_set_ref.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox_set_ref.Text = textBox_set_ref.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox_set_ref.Text = textBox_set_ref.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox_set_ref.Text = textBox_set_ref.Text + "9";
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            textBox_set_ref.Text = "";
        }

        private void button_nokta_Click(object sender, EventArgs e)
        {
            if (textBox_set_ref.Text.IndexOf(",") <= 0)         //sayida virgul yoksa
                if (textBox_set_ref.Text.Length == 0)           //karakter yoksa "0." ekle
                    textBox_set_ref.Text = "0,";
                else
                    textBox_set_ref.Text = textBox_set_ref.Text + ",";  //sayi varsa sonuna . ekle
        }

        private void button_arti_eksi_Click(object sender, EventArgs e)
        {
            if (textBox_set_ref.Text.Length > 0)
                if (textBox_set_ref.Text.Substring(0, 1) == "-")
                    textBox_set_ref.Text = textBox_set_ref.Text.Substring(1); //sayinin basinda - varsa sil
                else
                    textBox_set_ref.Text = "-" + textBox_set_ref.Text.Substring(0); //yoksa - ekle
        }

        
        
    }
    }


