using Amazon.Rekognition;
using Amazon.Rekognition.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DemoDiesAWS
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtCodigo.Text);
        }

        private async void btnVerificar_Click(object sender, EventArgs e)
        {
            ofdArchivo.ShowDialog();
            pbImage.ImageLocation = ofdArchivo.FileName;

            String photo = ofdArchivo.FileName;
            Amazon.Rekognition.Model.Image image = new Amazon.Rekognition.Model.Image();

            try
            {
                using (FileStream fs = new FileStream(photo, FileMode.Open, FileAccess.Read))
                {
                    byte[] data = null;
                    data = new byte[fs.Length];
                    fs.Read(data, 0, (int)fs.Length);
                    image.Bytes = new MemoryStream(data);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la imagen: " + photo);
                
            }
            AmazonRekognitionClient rekognitionClient = new AmazonRekognitionClient();

            DetectLabelsRequest request = new DetectLabelsRequest()
            {
                Image = image
            };
            DetectLabelsResponse response = await rekognitionClient.DetectLabelsAsync(request);

            foreach (var item in response.Labels)
            {
                txtSalida.Text += item.Name + "\r\n"; 
            }

            DetectModerationLabelsRequest request1 = new DetectModerationLabelsRequest()
            {
                Image = image
            };

            DetectModerationLabelsResponse response1 = await rekognitionClient.DetectModerationLabelsAsync(request1);

            foreach (var item in response1.ModerationLabels)
            {
                txtSalida.Text += item.Name + " " + item.Confidence.ToString() + "\r\n";
            }
            RecognizeCelebritiesRequest request2 = new RecognizeCelebritiesRequest() { Image = image };

            RecognizeCelebritiesResponse response2 = await rekognitionClient.RecognizeCelebritiesAsync(request2);

            foreach (var item in response2.CelebrityFaces)
            {
                txtSalida.Text += item.Name + "\r\n";
            }

            // RecognizeCelebritiesRequest request1 = new RecognizeCelebritiesRequest() { Image = image };
            // RecognizeCelebritiesResponse response1 = await rekognitionClient.RecognizeCelebritiesAsync(request1);

            // foreach (var item in response1.CelebrityFaces)
            //{
            //    txtSalida.Text += item.Name + "\n";
            //}
        }

    }
}
