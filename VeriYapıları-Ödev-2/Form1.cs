using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriYap�lar�_�dev_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num;
        string isim;
        double ort;
        Node head;
        private void BtnEkle_Click(object sender, EventArgs e)
        {  
            if(txtNumara.Text=="")
            {
                MessageBox.Show("L�tfen ��rencinin numaras�n� giriniz.");
                
                return;
            }
            if (txtAdSoyad.Text == "")
            {
                MessageBox.Show("L�tfen ��rencinin ad�n� giriniz.");
                txtAdSoyad.Clear();
                return;
            }
            if (txtOrtalama.Text=="")
            {
                MessageBox.Show("L�tfen ��rencinin ortalamas�n� giriniz.");
                
                return;
            }
            ErrorProvider provider = new ErrorProvider();
            bool say� = SayiMi(txtNumara.Text);
            bool say�2 = SayiMi(txtOrtalama.Text);
            if (say�)
                num =Convert.ToInt32(txtNumara.Text);
            else
            {
                provider.SetError(txtNumara,"L�tfen say� giriniz.");
                txtNumara.Clear();
                return;
            }
            isim = txtAdSoyad.Text;
            if(say�2)
                ort = Convert.ToDouble(txtOrtalama.Text);
            else
            {
                provider.SetError(txtOrtalama, "L�tfen say� giriniz.");
                txtOrtalama.Clear();
                return;
            }         
            if (rbBasa.Checked)
            {
                basaEkle(num,isim,ort);
                printList();
            }
            else if(rbS�raya.Checked)
            {
               sonaEkle(num, isim, ort);
               s�ralaOrt();
                printList();
            }
            else
            {
                sonaEkle(num,isim,ort);
                printList();
            }
            listeBo�Mu();
        }
        void basaEkle(int numara, string isim,double ortalama)//okey
        {
            Node yeni = new Node(numara, isim,ortalama);
            if (yeni.ort >= 100 || yeni.ort <= 0)
            {
                MessageBox.Show("S�nav ortalamas� 100'den b�y�k 0'dan k���k olamaz.");
                txtOrtalama.Clear();
                return;
            }
            if (head == null)
            {
                yeni.sonraki = head;
                head = yeni;
                return;
            }
            if(head.num==numara)
            {
                MessageBox.Show("Ayn� numarada ba�ka bir ��renci olamaz");
                txtNumara.Clear();
                return;
            }
            yeni.sonraki = head;
            head = yeni;
        }
        void printList()//okey
        {
            listBoxS�ral�.Items.Clear();
            Node tnode = head;
            while (tnode != null)
            {
                listBoxS�ral�.Items.Add(tnode.num + tnode.isim + tnode.ort);
                tnode = tnode.sonraki;
            }
        }
        void sonaEkle(int num, string isim, double ort)//okey
        {
            Node yeni = new Node(num, isim, ort);
            if (yeni.ort >= 100 || yeni.ort <= 0)
            {
                MessageBox.Show("S�nav ortalamas� 100'den b�y�k 0'dan k���k olamaz.");
                txtOrtalama.Clear();
                return;
            }
            if (head == null)
            {
                head = yeni;
                return;
            }
            yeni.sonraki = null;
            Node son = head;
            while (son.sonraki != null)
                son = son.sonraki;
            if (son.num == yeni.num)
            {
                MessageBox.Show("Ayn� numarada ba�ka bir ��renci olamaz");
                txtNumara.Clear();
                return;
            }

            son.sonraki = yeni;
            return;
        }
        int listeBoyu()//okey//
        {
            int n = 0;
            Node aktif = head;
            if(aktif==null)
            {
                return n;
            }
            while (aktif.sonraki != null)
            {
                aktif = aktif.sonraki;
                n++;
            }
            return n+1 ;
        }
        double[] diziyeAktarmaOrt(int i)//okey
        {
            Node current = head;
            double[] dizi = new double[i];
            for (int l = 0; l < dizi.Length; l++)
            {
                dizi[l] = current.ort;
                current = current.sonraki;
            }
            return dizi;
        }
        void s�ralaOrt()//okey
        {
            int listeBoyutu = listeBoyu();
            double[] dizi = diziyeAktarmaOrt(listeBoyutu);
            int[] numara = diziyeAktarmaNo();
            string[] isim = diziyeAktarmaIsim();
            for (int i = 1; i < listeBoyutu; i++)
            {
                for (int j = 0; j < listeBoyutu-1; j++)
                {
                    if (dizi[j] > dizi[j + 1])
                    {
                        double gecici = dizi[j + 1];
                        int ge�ici1 = numara[j + 1];
                        string ge�ici2 = isim[j + 1];
                        dizi[j + 1] = dizi[j];
                        numara[j + 1] = numara[j];
                        isim[j + 1] = isim[j];
                        dizi[j] = gecici;
                        numara[j] = ge�ici1;
                        isim[j] = ge�ici2;
                    }
                }
            }
            Node current =head;
            for (int f = 0; f < listeBoyutu; f++)
            {
                current.ort = dizi[f];
                current.isim = isim[f];
                current.num = numara[f];
                current = current.sonraki;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listeBo�Mu();
        }
        private void BtnListeBoyu_Click(object sender, EventArgs e)
        {
            
           lblListeBoyu.Text=""+ listeBoyu()+"";
        }
        int[] diziyeAktarmaNo()
        {
            Node current =head;
            int[] dizi = new int[listeBoyu()];
            for (int l = 0; l < dizi.Length; l++)
            {
                dizi[l] = current.num;
                current = current.sonraki;
            }
            return dizi;
        }
        string[] diziyeAktarmaIsim()
        {
            Node current = head;
            string[] dizi = new string[listeBoyu()];
            for (int l = 0; l < dizi.Length; l++)
            {
                dizi[l] = current.isim;
                current = current.sonraki;
            }
            return dizi;
        }
        Node[] diziyeAktarma()
        {
            int i = listeBoyu();
            Node[]dizi = new Node[i];
            Node current = head;
            
            for (int l = 0; l < dizi.Length; l++)
            {
                
                dizi[l] = current;
                current = current.sonraki;
            }
            return dizi;
        }
        void isimS�rala()
        {
            Node[] dizi = diziyeAktarma();
            string[] isim = diziyeAktarmaIsim();
            Array.Sort(isim);
            Node temp;
            for (int i = 0; i < dizi.Length; i++)
            {
                for (int j = 0; j < dizi.Length; j++)
                {
                    if (dizi[i].isim == isim[j])
                    {
                        temp = dizi[j];
                        dizi[j] = dizi[i];
                        dizi[i] = temp;
                    }
                }
            }
            listBoxS�ral�.Items.Clear();
            for (int i = 0; i < dizi.Length; i++)
            {
                listBoxS�ral�.Items.Add(dizi[i].num + dizi[i].isim + dizi[i].ort);
            }
        }
        void numS�rala()
        {
            int listeBoyutu = listeBoyu();
            double[] dizi = diziyeAktarmaOrt(listeBoyutu);
            int[] numara = diziyeAktarmaNo();
            string[] isim = diziyeAktarmaIsim();
            for (int i = 1; i < listeBoyutu; i++)
            {
                for (int j = 0; j < listeBoyutu - 1; j++)
                {
                    if (numara[j] > numara[j + 1])
                    {
                        double gecici = dizi[j + 1];
                        int ge�ici1 = numara[j + 1];
                        string ge�ici2 = isim[j + 1];
                        dizi[j + 1] = dizi[j];
                        numara[j + 1] = numara[j];
                        isim[j + 1] = isim[j];
                        dizi[j] = gecici;
                        numara[j] = ge�ici1;
                        isim[j] = ge�ici2;
                    }
                }
            }
            Node current = head;
            for (int f = 0; f < listeBoyutu; f++)
            {
                current.ort = dizi[f];
                current.isim = isim[f];
                current.num = numara[f];
                current = current.sonraki;
            }
        }
        private void BtnSilme_Click(object sender, EventArgs e)
        {
            if(rbBastakini.Checked)
            {
                bastakiniSil();
                printList();
            }
            else if(rbGirilenS�ray�.Checked)
            {
                int s�ra = Convert.ToInt32(txtS�ra.Text); 
                girilenS�ray�Sil(s�ra);
                printList();
            }
            else if(rbGirilenNumaray�.Checked)
            {
                int numara = Convert.ToInt32(txtS�ra.Text);
                girilenNoSil(numara);
                printList();
            }
            else if(rbSondakini.Checked)
            {
                sondakiniSil();
                printList();
            }
            else//t�m�n� sil
            {
                head = null;
                printList();
            }
            listeBo�Mu();
        }
        void bastakiniSil()
        {
            if (head == null)
            {
                MessageBox.Show("liste bo�");
                return;
            }
            head = head.sonraki;
        }
        void sondakiniSil()
        {
            Node current = head;
            Node �nceki = null;
            if(current==null)
            {
                MessageBox.Show("Liste Bo�.");
                return;
            }
            if( head.sonraki == null)
            {
                head = null;
                return;
            }
            while (current.sonraki!=null)
            {
                �nceki = current;
                current = current.sonraki;
            }
            �nceki.sonraki = null;
        }
        void girilenS�ray�Sil(int s�ra)
        {
            if (head == null)
            {
                MessageBox.Show("Liste bo�");
                return;
            }
            Node temp = head;

            if (s�ra == 0)
            {
                head = temp.sonraki;
                return;
            }
            for (int i = 0; temp != null && i < s�ra - 1; i++)
                temp = temp.sonraki;

            if (temp == null || temp.sonraki == null)
            {
                MessageBox.Show("Girdi�iniz s�ra ��rencilerden fazla.");
                txtS�ra.Clear();
                return;
            }
            Node sonraki = temp.sonraki.sonraki;
            temp.sonraki = sonraki;
        }
        void girilenNoSil(int numara)
        {
            Node temp = head;
            Node �nceki = null;
            if (temp != null && temp.num == numara)
            {
                head = temp.sonraki; 
                return;
            }
            while (temp != null && temp.num != numara)
            {
                �nceki = temp;
                temp = temp.sonraki;
            }
            if (temp == null)
            {
                MessageBox.Show("Girdi�iniz numarada bir ��renci yok.");
                txtS�ra.Clear();
                return;
            }
            �nceki.sonraki=temp.sonraki;
        }
        private void BtnListele_Click_1(object sender, EventArgs e)
        {
            if (rbOrtalamayaG�re.Checked)
            {
                s�ralaOrt();
                printList();
            }
            else if (rbAdaG�re.Checked)
            {
                isimS�rala();
            }
            else
            {
                numS�rala();
                printList();
            }
        }

        private void Button1_Click(object sender, EventArgs e)//listeBo�
        {
        }
        void listeBo�Mu()
        {
            if (head == null)
            {
                btnListeBos.BackColor = Color.Red;
                btnListeBos.ForeColor = Color.White;
                btnListeBos.Text = "L�STE BO�";
            }
            else
            {
                btnListeBos.ForeColor = Color.White;
                btnListeBos.BackColor = Color.YellowGreen;
                btnListeBos.Text = "L�STE DOLU";
            }
        }
        private void TxtNumara_TextChanged(object sender, EventArgs e)
        {
            
        }
        bool SayiMi(string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr))
                    return false;
            }
            return true;
        }  
    }
}
