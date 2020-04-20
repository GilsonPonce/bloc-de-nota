using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bloc_de_notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Cut();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Copy();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Paste();
        }

        private void rehacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Redo();
        }

        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Undo();
        }

        private void selecionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.SelectAll();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            editor.Cut();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            editor.Copy();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            editor.Paste();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            editor.Redo();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            editor.Undo();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            editor.SelectAll();
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.Font = editor.Font;
            if (font.ShowDialog() == DialogResult.OK)
            {
                editor.Font = font.Font;
            }
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.Font = editor.Font;
            if (font.ShowDialog() == DialogResult.OK)
            {
                editor.Font = font.Font;
            }
        }

        private void colorDeFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                editor.ForeColor = color.Color; 
            }
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                editor.ForeColor = color.Color;
            }
        }

        private void colorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                editor.BackColor = color.Color;
            }
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                editor.BackColor = color.Color;
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editor.Text != "")
            {
                if (MessageBox.Show("Desea guardar el archivo", "Bloc de notas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveFileDialog save = new SaveFileDialog();
                    System.IO.StreamWriter myStreamReader = null;
                    save.Filter = "text [*.txt]|*.txt|HTML(*.html*)|*.html|All Files[*.*]|*.*";
                    save.CheckPathExists = true;
                    save.Title = "Guardar nuevo";
                    save.ShowDialog(this);
                    try
                    {
                        myStreamReader = System.IO.File.AppendText(save.FileName);
                        myStreamReader.Write(editor.Text);
                        myStreamReader.Flush();
                    }
                    catch (Exception) {}

                }
                
                {
                    editor.Clear();
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (editor.Text != "")
            {
                if (MessageBox.Show("Desea guardar el archivo", "Bloc de notas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveFileDialog save = new SaveFileDialog();
                    System.IO.StreamWriter myStreamReader = null;
                    save.Filter = "text [*.txt]|*.txt|HTML(*.html*)|*.html|All Files[*.*]|*.*";
                    save.CheckPathExists = true;
                    save.Title = "Guardar nuevo";
                    save.ShowDialog(this);
                    try
                    {
                        myStreamReader = System.IO.File.AppendText(save.FileName);
                        myStreamReader.Write(editor.Text);
                        myStreamReader.Flush();
                    }
                    catch (Exception) { }

                }

                {
                    editor.Clear();
                }
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            System.IO.StreamReader myStreamReader = null;
            open.Filter = "text [*.txt]|*txt|All Files[*,*]|*,*";
            open.CheckFileExists = true;
            open.Title = "Abrir";
            open.ShowDialog(this);
            try
            {
                open.OpenFile();
                myStreamReader = System.IO.File.OpenText(open.FileName);
                editor.Text = myStreamReader.ReadToEnd();
            }
            catch (Exception) {}
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            System.IO.StreamReader myStreamReader = null;
            open.Filter = "text [*.txt]|*txt|All Files[*.*]|*.*";
            open.CheckFileExists = true;
            open.Title = "Abrir";
            open.ShowDialog(this);
            try
            {
                open.OpenFile();
                myStreamReader = System.IO.File.OpenText(open.FileName);
                editor.Text = myStreamReader.ReadToEnd();
            }
            catch (Exception) { MessageBox.Show("Archivo no encontrado"); }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            System.IO.StreamWriter myStreamReader = null;
            save.Filter = "text [*.txt]|*.txt|HTML(*.html*)|*.html|All Files[*.*]|*.*";
            save.CheckPathExists = true;
            save.Title = "Guardar";
            save.ShowDialog(this);
            try
            {
                myStreamReader = System.IO.File.AppendText(save.FileName);
                myStreamReader.Write(editor.Text);
                myStreamReader.Flush();
            }
            catch (Exception) { }
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog(editor);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            System.IO.StreamWriter myStreamReader = null;
            save.Filter = "text [*.txt]|*.txt|HTML(*.html*)|*.html|All Files[*.*]|*.*";
            save.CheckPathExists = true;
            save.Title = "Guardar";
            save.ShowDialog(this);
            try
            {
                myStreamReader = System.IO.File.AppendText(save.FileName);
                myStreamReader.Write(editor.Text);
                myStreamReader.Flush();
            }
            catch (Exception) { }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog(editor);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) 
            {
                if (MessageBox.Show("Desea guardar antes de salir", "Bloc de notas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveFileDialog save = new SaveFileDialog();
                    System.IO.StreamWriter myStreamReader = null;
                    save.Filter = "text [*.txt]|*.txt|HTML(*.html*)|*.html|All Files[*.*]|*.*";
                    save.CheckPathExists = true;
                    save.Title = "Guardar como";
                    save.ShowDialog(this);
                    try
                    {
                        myStreamReader = System.IO.File.AppendText(save.FileName);
                        myStreamReader.Write(editor.Text);
                        myStreamReader.Flush();
                    }
                    catch (Exception) { }

                }
              
                {
                    Application.Exit();
                }
            
            }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            System.IO.StreamWriter myStreamReader = null;
            save.Filter = "text [*.txt]|*.txt|HTML(*.html*)|*.html|All Files[*.*]|*.*";
            save.CheckPathExists = true;
            save.Title = "Guardar como";
            save.ShowDialog(this);
            try
            {
                myStreamReader = System.IO.File.AppendText(save.FileName);
                myStreamReader.Write(editor.Text);
                myStreamReader.Flush();
            }
            catch (Exception) {}


        }

        private void editor_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
