using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DIAE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int poinermaths(int offset)
        {
            offset = offset - 0x200;
            return offset + 0xC00000;
        }
        public void arraywriter(byte[] towrite, int offset)
        {
            textBox1.Text = poinermaths(offset).ToString("X");
            using (BinaryWriter bnw = new BinaryWriter(File.Open(openFileDialog1.FileName, FileMode.Open)))
            {
                bnw.BaseStream.Position = (long)offset;
                bnw.Write((byte[])towrite);
                bnw.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var rawtext = new List<byte>();
                char[] datastream = richTextBox1.Text.ToCharArray();
                int character = 0;
                while (true)
                {
                    string todo = "";
                    if (datastream[character] == '[')
                    {
                        int adder = 1;
                        while (true)
                        {
                            if (datastream[character + adder] == ']')
                            {
                                character = character + adder;
                                break;
                            }
                            todo = todo + datastream[character + adder];
                            adder = adder + 1;
                        }
                    }
                    if (todo.Contains("LOADFACE"))
                    {
                        rawtext.Add(0x00);
                        rawtext.Add(0x3D);
                        rawtext.Add(0x00);
                        rawtext.Add(0x3F);
                    }
                    if (todo == "CLEARALL")
                    {
                        rawtext.Add(0x00);
                        rawtext.Add(0x17);
                    }
                    if (todo == "CLEARFACE")
                    {
                        rawtext.Add(0x00);
                        rawtext.Add(0x3B);
                    }
                    if (todo == "TARGRIGHT")
                    {
                        rawtext.Add(0x7);
                    }
                    else if (todo == "TARGLEFT")
                    {
                        rawtext.Add(0x6);
                    }
                    else if (todo == "END")
                    {
                        rawtext.Add(0x1);
                        break;
                    }
                    else if (todo == "NEWLINE")
                    {
                        rawtext.Add(0x2);
                    }
                    else if (todo == "SCROLL")
                    {
                        rawtext.Add(0x4);
                    }
                    else if (todo == "CLEARTEXT")
                    {
                        rawtext.Add(0x3);
                    }
                    else if (todo == "WAITBUTTON")
                    {
                        rawtext.Add(0x8);
                    }
                    else if (todo == "DEFFONT")
                    {
                        rawtext.Add(0x9);
                    }
                    else if (todo.Contains("0x"))
                    {
                        int byter = Convert.ToInt32(todo, 16);
                        rawtext.Add(Convert.ToByte(byter));
                    }
                    else
                    {
                        byte[] bufferbys = ASCIIEncoding.UTF8.GetBytes(datastream[character].ToString());
                        byte bufferby = bufferbys[0];
                        if (bufferby == 0xA)
                        {

                        }
                        else if (bufferby == 0x5D)
                        {

                        }
                        else
                        {
                            byte bufferbyparsed;
                            bufferbyparsed = 0x0;
                            if (datastream[character] == 'A')
                            {
                                bufferbyparsed = 0x10;
                            }
                            if (datastream[character] == 'B')
                            {
                                bufferbyparsed = 0x11;
                            }
                            if (datastream[character] == 'C')
                            {
                                bufferbyparsed = 0x12;
                            }
                            if (datastream[character] == 'D')
                            {
                                bufferbyparsed = 0x13;
                            }
                            if (datastream[character] == 'E')
                            {
                                bufferbyparsed = 0x14;
                            }
                            if (datastream[character] == 'F')
                            {
                                bufferbyparsed = 0x15;
                            }
                            if (datastream[character] == 'G')
                            {
                                bufferbyparsed = 0x16;
                            }
                            if (datastream[character] == 'H')
                            {
                                bufferbyparsed = 0x17;
                            }
                            if (datastream[character] == 'I')
                            {
                                bufferbyparsed = 0x18;
                            }
                            if (datastream[character] == 'J')
                            {
                                bufferbyparsed = 0x19;
                            }
                            if (datastream[character] == 'K')
                            {
                                bufferbyparsed = 0x1A;
                            }
                            if (datastream[character] == 'L')
                            {
                                bufferbyparsed = 0x1B;
                            }
                            if (datastream[character] == 'M')
                            {
                                bufferbyparsed = 0x1C;
                            }
                            if (datastream[character] == 'N')
                            {
                                bufferbyparsed = 0x1D;
                            }
                            if (datastream[character] == 'O')
                            {
                                bufferbyparsed = 0x1E;
                            }
                            if (datastream[character] == 'P')
                            {
                                bufferbyparsed = 0x1F;
                            }
                            if (datastream[character] == 'Q')
                            {
                                bufferbyparsed = 0x20;
                            }
                            if (datastream[character] == 'R')
                            {
                                bufferbyparsed = 0x21;
                            }
                            if (datastream[character] == 'S')
                            {
                                bufferbyparsed = 0x22;
                            }
                            if (datastream[character] == 'T')
                            {
                                bufferbyparsed = 0x23;
                            }
                            if (datastream[character] == 'U')
                            {
                                bufferbyparsed = 0x24;
                            }
                            if (datastream[character] == 'V')
                            {
                                bufferbyparsed = 0x25;
                            }
                            if (datastream[character] == 'W')
                            {
                                bufferbyparsed = 0x26;
                            }
                            if (datastream[character] == 'X')
                            {
                                bufferbyparsed = 0x27;
                            }
                            if (datastream[character] == 'Y')
                            {
                                bufferbyparsed = 0x28;
                            }
                            if (datastream[character] == 'Z')
                            {
                                bufferbyparsed = 0x29;
                            }
                            if (datastream[character] == 'a')
                            {
                                bufferbyparsed = 0x2A;
                            }
                            if (datastream[character] == 'b')
                            {
                                bufferbyparsed = 0x2B;
                            }
                            if (datastream[character] == 'c')
                            {
                                bufferbyparsed = 0x2C;
                            }
                            if (datastream[character] == 'd')
                            {
                                bufferbyparsed = 0x2D;
                            }
                            if (datastream[character] == 'e')
                            {
                                bufferbyparsed = 0x2E;
                            }
                            if (datastream[character] == 'f')
                            {
                                bufferbyparsed = 0x2F;
                            }
                            if (datastream[character] == 'g')
                            {
                                bufferbyparsed = 0x30;
                            }
                            if (datastream[character] == 'h')
                            {
                                bufferbyparsed = 0x31;
                            }
                            if (datastream[character] == 'i')
                            {
                                bufferbyparsed = 0x32;
                            }
                            if (datastream[character] == 'j')
                            {
                                bufferbyparsed = 0x33;
                            }
                            if (datastream[character] == 'k')
                            {
                                bufferbyparsed = 0x34;
                            }
                            if (datastream[character] == 'l')
                            {
                                bufferbyparsed = 0x35;
                            }
                            if (datastream[character] == 'm')
                            {
                                bufferbyparsed = 0x36;
                            }
                            if (datastream[character] == 'n')
                            {
                                bufferbyparsed = 0x37;
                            }
                            if (datastream[character] == 'o')
                            {
                                bufferbyparsed = 0x38;
                            }
                            if (datastream[character] == 'p')
                            {
                                bufferbyparsed = 0x39;
                            }
                            if (datastream[character] == 'q')
                            {
                                bufferbyparsed = 0x3A;
                            }
                            if (datastream[character] == 'r')
                            {
                                bufferbyparsed = 0x3B;
                            }
                            if (datastream[character] == 's')
                            {
                                bufferbyparsed = 0x3C;
                            }
                            if (datastream[character] == 't')
                            {
                                bufferbyparsed = 0x3D;
                            }
                            if (datastream[character] == 'u')
                            {
                                bufferbyparsed = 0x3E;
                            }
                            if (datastream[character] == 'v')
                            {
                                bufferbyparsed = 0x3F;
                            }
                            if (datastream[character] == 'w')
                            {
                                bufferbyparsed = 0x40;
                            }
                            if (datastream[character] == 'x')
                            {
                                bufferbyparsed = 0x41;
                            }
                            if (datastream[character] == 'y')
                            {
                                bufferbyparsed = 0x42;
                            }
                            if (datastream[character] == 'z')
                            {
                                bufferbyparsed = 0x43;
                            }
                            if (datastream[character] == '{')
                            {
                                bufferbyparsed = 0x44;
                            }
                            if (datastream[character] == '}')
                            {
                                bufferbyparsed = 0x45;
                            }
                            if (datastream[character] == '(')
                            {
                                bufferbyparsed = 0x46;
                            }
                            if (datastream[character] == ')')
                            {
                                bufferbyparsed = 0x47;
                            }
                            if (datastream[character] == ',')
                            {
                                bufferbyparsed = 0x48;
                            }
                            if (datastream[character] == '.')
                            {
                                bufferbyparsed = 0x49;
                            }
                            if (datastream[character] == '!')
                            {
                                bufferbyparsed = 0x4A;
                            }
                            if (datastream[character] == '?')
                            {
                                bufferbyparsed = 0x4B;
                            }
                            if (datastream[character] == '\"')
                            {
                                bufferbyparsed = 0x4C;
                            }
                            if (datastream[character] == ' ')
                            {
                                bufferbyparsed = 0x4F;
                            }
                            if (datastream[character] == '_')
                            {
                                bufferbyparsed = 0x50;
                            }
                            if (datastream[character] == '\'')
                            {
                                bufferbyparsed = 0x51;
                            }
                            if (datastream[character] == '0')
                            {
                                bufferbyparsed = 0xb1;
                            }
                            if (datastream[character] == '1')
                            {
                                bufferbyparsed = 0xb2;
                            }
                            if (datastream[character] == '2')
                            {
                                bufferbyparsed = 0xb3;
                            }
                            if (datastream[character] == '3')
                            {
                                bufferbyparsed = 0xb4;
                            }
                            if (datastream[character] == '4')
                            {
                                bufferbyparsed = 0xb5;
                            }
                            if (datastream[character] == '5')
                            {
                                bufferbyparsed = 0xb6;
                            }
                            if (datastream[character] == '6')
                            {
                                bufferbyparsed = 0xb7;
                            }
                            if (datastream[character] == '7')
                            {
                                bufferbyparsed = 0xb8;
                            }
                            if (datastream[character] == '8')
                            {
                                bufferbyparsed = 0xb9;
                            }
                            if (datastream[character] == '9')
                            {
                                bufferbyparsed = 0xba;
                            }
                            rawtext.Add(bufferbyparsed);
                        }
                    }
                    character = character + 1;
                }
                if (!checkBox1.Checked)
                {
                    arraywriter(rawtext.ToArray(), (int)numericUpDown1.Value);
                }
                int goest = 0;
                richTextBox2.Text = "";
                while (true)
                {
                    try
                    {
                        richTextBox2.Text = richTextBox2.Text + rawtext.ToArray()[goest].ToString("X") + "";
                        goest = goest + 1;
                    }
                    catch
                    {
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Finished!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
