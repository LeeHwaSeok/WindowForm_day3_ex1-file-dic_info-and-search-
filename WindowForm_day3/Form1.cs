using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//디렉토리 다루기
using System.IO;

namespace WindowForm_day3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb_dic.Items.Clear();

            //디렉토리 string형태로 목록찾기 [기본형식]
            string[] apaths = Directory.GetDirectories(@"C:\WINDOWS\system32");
            //Environment.SystemDirectory == @"C:\WINDOWS\system32" 

            //foreach 형식으로 각 폴더명을 ib_dic에 추가한다. [기본형식]
            foreach (string apath in apaths) { lb_dic.Items.Add(apath); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lb_file.Items.Clear();

            //파일을 string형태로 파일찾기 [기본형식]  -> "*.*" or "*.exe"
            string[] afiles = Directory.GetFiles(Environment.SystemDirectory, "*.*");

            //foreach 형식으로 각 파일명을 ib_file에 추가한다. [기본형식]
            foreach (string afile in afiles) { lb_file.Items.Add(afile); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lb_dicinfo.Items.Clear();

            //dirinfo는 인스턴스 형식이라 new로 할당해줘야함.
            //file, dir은 정적형식이라 할당이 필요없음
            DirectoryInfo dirinfo = new DirectoryInfo(@"C:\Windows");

            lb_dicinfo.Items.Clear();

            //예외처리 생성정보 확인 => Exists
            if (dirinfo.Exists)
            { //디렉토리 대략적인 정보
                lb_dicinfo.Items.Add("전체경로 : " + dirinfo.FullName);
                lb_dicinfo.Items.Add("디렉토리 이름 : " + dirinfo.Name);
                lb_dicinfo.Items.Add("생성일 : " + dirinfo.CreationTime);
                lb_dicinfo.Items.Add("속성 : " + dirinfo.Attributes);
                lb_dicinfo.Items.Add("루트 : " + dirinfo.Root);
            }


        }
    }
}
