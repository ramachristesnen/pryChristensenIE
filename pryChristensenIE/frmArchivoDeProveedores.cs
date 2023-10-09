﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace pryChristensenIE
{
    public partial class frmArchivoDeProveedores : Form
    {
        public frmArchivoDeProveedores()
        {
            InitializeComponent();
        }

        private void frmArchivoDeProveedores_Load(object sender, EventArgs e)
        {
            DirectoryInfo info = new DirectoryInfo(@"../../");
            string ruta = info.FullName + "Datos";
            CargarTreeView(ruta, info.Name);
        }
        private void TraerCarpetasYArchivos(TreeNode NodoPadre, string ruta)
        {
            try
            {
                string[] carpetas = Directory.GetDirectories(ruta);
                string[] archivos = Directory.GetFiles(ruta);

                foreach (string carpeta in carpetas)
                {
                    TreeNode NodoDeCarpeta = new TreeNode(Path.GetFileName(carpeta));
                    NodoPadre.Nodes.Add(NodoDeCarpeta);
                    TraerCarpetasYArchivos(NodoDeCarpeta, carpeta);
                }

                foreach (string archivo in archivos)
                {
                    TreeNode NodoDeArchivo = new TreeNode(Path.GetFileName(archivo));
                    NodoPadre.Nodes.Add(NodoDeArchivo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar carpetas y archivos: " + ex.Message);
            }
        }


        private void CargarTreeView(string RutaCarpetaRaiz, string NombreCarpeta)
        {
            twCarpetasProvedores.Nodes.Clear();

            if (Directory.Exists(RutaCarpetaRaiz))
            {
                TreeNode NodoRaiz = new TreeNode(NombreCarpeta);
                twCarpetasProvedores.Nodes.Add(NodoRaiz);
                TraerCarpetasYArchivos(NodoRaiz, RutaCarpetaRaiz);
            }
        }

        private void twCarpetasProvedores_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            lblDatos.Text = "";
            try
            {
                DirectoryInfo info = new DirectoryInfo(@"../../");
                string RutaArchivo = info.FullName + "\\" + e.Node.FullPath;

                if (File.Exists(RutaArchivo))
                {
                    using (StreamReader LectorArchivos = new StreamReader(RutaArchivo))
                    {
                        while (!LectorArchivos.EndOfStream)
                        {
                            lblDatos.Text += LectorArchivos.ReadLine();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El archivo no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message);
            }
        }
    }
}
