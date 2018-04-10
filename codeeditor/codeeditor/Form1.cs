using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using mshtml;


namespace WebDev2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public string filepath = "C:\\tmp\\html1.html";

        List<Regex> html_hl_a1 = new List<Regex> { };
        List<Regex> html_hl_a2 = new List<Regex> { };
        List<Regex> html_hl_a3 = new List<Regex> { };
        List<Regex> html_hl_a4 = new List<Regex> { };
        string[] html_a1 = new string[] { "!DOCTYPE", "html", "head", "body", "br", "li", "ul", "h1", "h2", "h3", "h4", "h5", "p", "b", "u", "sub", "sup", "i", "input", "button", "div", "link", "style", "meta", "title", "script", "img", "a" };
        string[] html_a2 = new string[] { "class", "id", "href", "ref", "width", "height", "max", "value", "text", "type", "onclick", "src", "name", "html" };
        string[] html_a3 = new string[] { "<", ">", "=", "/" };
        string[] html_a4 = new string[] { "'", "\"", "px", "%", "button", "range", "text", "number" };
        string[] css_a1 = new string[] { ":", "{", "}","ulr" };
        string[] css_a2 = new string[] { "html", "head", "body", "br", "li", "ul", "h1", "h2", "h3", "h4", "h5", "p", "b", "u", "sub", "sup", "i", "input", "button", "div", "link", "style", "meta", "title", "script", "img", "a"};
        string[] js_a1 = new string[] { "var", "function", "if", "else","[]", "typeof", "alert", "document", "window", "return" };

        public string[] undolists = new string[5000];
        public long changesmade = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(filepath))
            {
                string tmps;
                using (StreamReader sr = new StreamReader(filepath))
                {
                    
                    tmps = sr.ReadToEnd();
                    sr.Close();
                }
                html_code_rtb.Text = tmps;
                view_f_browse.Url = new Uri(filepath);
            }
            foreach (string x in html_a1)
            {
                html_hl_a1.Add(new Regex(x));
            }
            foreach (string x in html_a2)
            {
                html_hl_a2.Add(new Regex(x));
            }
            foreach (string x in html_a3)
            {
                html_hl_a3.Add(new Regex(x));
            }
            foreach (string x in html_a4)
            {
                html_hl_a4.Add(new Regex(x));
            }
            changesmade = 0;
            undolists[changesmade] = (html_code_rtb.Text);
            
        }

        private void html_code_rtb_TextChanged(object sender, EventArgs e)
        {
            highlight(html_code_rtb, html_hl_a1, Color.FromArgb(128, 192, 255),true);
            highlight(html_code_rtb, html_hl_a2, Color.FromArgb(192,128,255),false);
            highlight(html_code_rtb, html_hl_a3, Color.FromArgb(128,128,128),false);
            highlight(html_code_rtb, html_hl_a4, Color.FromArgb(64, 255, 64), false);

            using (StreamWriter sw = new StreamWriter(filepath))
            {
                sw.Write(html_code_rtb.Text);
                sw.Close();
                
            }
            if (!undoed)
            {
                changesmade++;
                undolists[changesmade] = (html_code_rtb.Text);
                if(changesmade >= undolists.Length-2)
                {
                    changesmade = 0;
                }
            }
            else
            {
                undoed = !undoed;
            }


        }
        public void highlight(RichTextBox crtb, List<Regex> code_hl, Color c, bool check_if)
        {
            int index = crtb.SelectionStart;
            foreach (Regex r in code_hl)
            {
                foreach (Match m in r.Matches(crtb.Text))
                {
                    if ((m.Index >= index - (m.Value.Length + 10)) && (m.Index <= index + (m.Value.Length + 10)))
                    {
                        if (check_if)
                        {
                            if ((m.Index - 1) >= 0)
                            {
                                if ((crtb.Text[m.Index - 1].ToString() == "<") || (crtb.Text[m.Index - 1].ToString() == "/"))
                                {
                                    crtb.Select(m.Index, m.Value.Length);
                                    crtb.SelectionColor = c;

                                    //code_text.SelectionStart = index;
                                    crtb.Select(index, 0);
                                    crtb.SelectionColor = Color.LightGray;
                                }
                            }

                        }
                        else
                        {
                            crtb.Select(m.Index, m.Value.Length);
                            crtb.SelectionColor = c;

                            //code_text.SelectionStart = index;
                            crtb.Select(index, 0);
                            crtb.SelectionColor = Color.LightGray;
                        }



                    }
                }

            }
        }
        public void highlightall(RichTextBox crtb, List<Regex> code_hl, Color c, bool check_if)
        {
            int index = crtb.SelectionStart;
            foreach (Regex r in code_hl)
            {
                foreach (Match m in r.Matches(crtb.Text))
                {
                    
                        if (check_if)
                        {
                            if ((m.Index - 1) >= 0)
                            {
                                if ((crtb.Text[m.Index - 1].ToString() == "<") || (crtb.Text[m.Index - 1].ToString() == "/"))
                                {
                                    crtb.Select(m.Index, m.Value.Length);
                                    crtb.SelectionColor = c;

                                    //code_text.SelectionStart = index;
                                    crtb.Select(index, 0);
                                    crtb.SelectionColor = Color.LightGray;
                                }
                            }

                        }
                        else
                        {
                            crtb.Select(m.Index, m.Value.Length);
                            crtb.SelectionColor = c;

                            //code_text.SelectionStart = index;
                            crtb.Select(index, 0);
                            crtb.SelectionColor = Color.LightGray;
                        }



                    
                }

            }
        }

        private void r_hl_btn_Click(object sender, EventArgs e)
        {
            highlightall(html_code_rtb, html_hl_a1, Color.FromArgb(128, 192, 255), true);
            highlightall(html_code_rtb, html_hl_a2, Color.FromArgb(192, 128, 255), false);
            highlightall(html_code_rtb, html_hl_a3, Color.FromArgb(128, 128, 128), false);
            highlightall(html_code_rtb, html_hl_a4, Color.FromArgb(64, 255, 64), false);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = saveFileDialog1.FileName;
                view_f_browse.Url = new Uri(filepath);
            }
        }

        private void code_tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            view_f_browse.Url = new Uri(filepath);
            view_f_browse.Refresh();
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog1.FileName;
                if (File.Exists(filepath))
                {
                    string tmps;
                    using (StreamReader sr = new StreamReader(filepath))
                    {

                        tmps = sr.ReadToEnd();
                        sr.Close();
                    }
                    html_code_rtb.Text = tmps;
                    
                    view_f_browse.Url = new Uri(filepath);
                }
                
            }
            
        }
        public bool listShow = false;

        
        public void add_txt(string add_s,short type)
        {
            //html_code_rtb.Text[html_code_rtb.Select()] = "<p>";
            html_code_rtb.SelectionLength=0;
            if ((type == 0)||(type == null))
            {
                html_code_rtb.SelectedText = "<" + add_s + "></" + add_s + ">";
                html_code_rtb.SelectionStart += 2 + add_s.Length;
            }
            else if(type == 1)
            {
                html_code_rtb.SelectedText = "<" + add_s + "/>";
                html_code_rtb.SelectionStart += 2 + add_s.Length;
            }else if (type == 2)
            {
                html_code_rtb.SelectedText = add_s;
            }


        }
        public void add_txt(string add_s)
        {
            //html_code_rtb.Text[html_code_rtb.Select()] = "<p>";
            html_code_rtb.SelectionLength = 0;
            html_code_rtb.SelectedText = "<" + add_s + "></" + add_s + ">";
            html_code_rtb.SelectionStart -= 3 + add_s.Length;
        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e){add_txt("p");}private void pToolStripMenuItem1_Click(object sender, EventArgs e){add_txt("p");}private void h1ToolStripMenuItem_Click(object sender, EventArgs e){add_txt("h1");}private void h2ToolStripMenuItem_Click(object sender, EventArgs e){add_txt("h2");}private void h3ToolStripMenuItem_Click(object sender, EventArgs e){add_txt("h3");}private void h4ToolStripMenuItem_Click(object sender, EventArgs e){add_txt("h4");}private void h5ToolStripMenuItem_Click(object sender, EventArgs e){add_txt("h5");}private void brToolStripMenuItem_Click(object sender, EventArgs e){add_txt("br",1);}private void outputToolStripMenuItem_Click(object sender, EventArgs e){add_txt("output",1);}private void bToolStripMenuItem_Click(object sender, EventArgs e){add_txt("b");}private void sToolStripMenuItem_Click(object sender, EventArgs e){add_txt("s");}private void iToolStripMenuItem_Click(object sender, EventArgs e){add_txt("i");}private void supToolStripMenuItem_Click(object sender, EventArgs e){add_txt("sup");}private void subToolStripMenuItem_Click(object sender, EventArgs e){add_txt("sub");}private void divToolStripMenuItem1_Click(object sender, EventArgs e){add_txt("div");}private void inputToolStripMenuItem1_Click(object sender, EventArgs e){add_txt("input",1);}private void outputToolStripMenuItem1_Click(object sender, EventArgs e){add_txt("output",1);}private void h1ToolStripMenuItem1_Click(object sender, EventArgs e){add_txt("h1");}private void h2ToolStripMenuItem1_Click(object sender, EventArgs e){add_txt("h2");}private void inputToolStripMenuItem_Click(object sender, EventArgs e){add_txt("input",1);}private void brToolStripMenuItem1_Click(object sender, EventArgs e){add_txt("br",1);}private void iframeToolStripMenuItem_Click(object sender, EventArgs e){add_txt("iframe");}private void divToolStripMenuItem_Click(object sender, EventArgs e){add_txt("div");}
        private void html5StartToolStripMenuItem_Click(object sender, EventArgs e) { html_code_rtb.SelectionLength = 0; html_code_rtb.SelectedText = "<!DOCTYPE>\n<html>\n<head>\n\n</head>\n<body>\n\n</body>\n</html>"; html_code_rtb.SelectionStart -= "\n</body>\n</html>".Length; }

        private void open_in_browser_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("file://"+filepath);
        }

        private void Color_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            System.Diagnostics.Process.Start("file://" + filepath);
        }

        private void textToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HtmlElement headElement = view_f_browse.Document.GetElementsByTagName("head")[0];
            HtmlElement scriptElement = view_f_browse.Document.CreateElement("script");
            IHTMLScriptElement element = (IHTMLScriptElement)scriptElement.DomElement;
            element.text = "function tellwebdev() { return (document.selection.createRange().text) }";
            headElement.AppendChild(scriptElement);
            MessageBox.Show(view_f_browse.Document.InvokeScript("tellwebdev").ToString());
        }
        public bool cntrl_in = false;
        public bool undoed = false;
        private void html_code_rtb_KeyDown(object sender, KeyEventArgs e)
        {
            if(ModifierKeys == Keys.Control)
            {
                if ((short)e.KeyCode == 49)
                {
                    add_txt("h1");
                }
                else if ((short)e.KeyCode == 50)
                {
                    add_txt("h2");
                }
                else if ((short)e.KeyCode == 51)
                {
                    add_txt("h3");
                }
                else if ((short)e.KeyCode == 52)
                {
                    add_txt("h4");
                }
                else if ((short)e.KeyCode == 53)
                {
                    add_txt("h5");
                }else if((short)e.KeyCode == 90)
                {
                    if (changesmade - 1 >= 0)
                    {
                        undoed = true;
                        changesmade--;
                        (html_code_rtb.Text) = undolists[changesmade];
                    }
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //(html_code_rtb.SelectedText)
            Clipboard.SetText(html_code_rtb.SelectedText);

        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_txt(Clipboard.GetText(), 2);
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            //DragDropEffects.Copy
            e.Effect = DragDropEffects.Link;
        }

        private void Form1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;
        }

        private void html_code_DragEnter(object sender, DragEventArgs e)
        {
            html_code_rtb.Visible = false;
            e.Effect = DragDropEffects.Link;
        }

        private void html_code_DragLeave(object sender, EventArgs e)
        {
            html_code_rtb.Visible = true;
            
        }

        private void html_code_DragEnter_1(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;

        }
    }
}
