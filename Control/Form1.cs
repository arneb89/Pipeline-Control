using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using NPlot;

namespace Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.pathToFolder = txtFolder.Text;
        }

        private string pathToFolder = null;

        /**************************Orders Identification***********************************/

        DataTable slice;
        DataTable orders_pos;
        DataTable orders_ident;
        DataTable locations_min;
        DataTable minima_ident;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.slice = new DataTable(this.pathToFolder + @"\Slice.txt");
                this.orders_pos = new DataTable(this.pathToFolder + @"\Orders.txt");
                this.orders_ident = new DataTable(this.pathToFolder + @"\orders_ident.dat");
            }
            catch
            {
                MessageBox.Show("Some of data files were not been found or they have incorrect structure...", "Error...");
                return;
            }
        }

        private void btnOrdIdent_RefreshPlot_Click(object sender, EventArgs e)
        {
            plotOrdIdent.Clear();

            if (this.slice == null || this.orders_pos == null || this.orders_ident == null) return;
                                 
            LinePlot lp = new LinePlot(this.slice.Data[1], this.slice.Data[0]);
            lp.Pen = new Pen(Color.Black, 2.0f);
            plotOrdIdent.Add(lp);


            if (cbOrdIdent_OrdPos.Checked)
            {
                for (int i = 0; i < orders_pos.Data[0].Length; i++)
                {
                    VerticalLine vl = new VerticalLine(orders_pos.Data[0][i]);
                    vl.Pen = new Pen(Color.Red);
                    plotOrdIdent.Add(vl);
                }
            }

            if (cbOrdIdent_IdentOrders.Checked)
            {
                for (int i = 0; i < this.orders_ident.Data[0].Length; i++)
                {
                    PointPlot pp = new PointPlot(new Marker(Marker.MarkerType.FilledCircle, 6, Color.Blue));
                    double[] xx = new double[1];
                    double[] yy = new double[1];
                    xx[0] = orders_ident.Data[0][i];
                    yy[0] = this.slice.Data[1][(int)orders_ident.Data[0][i]] + 100;
                    pp.OrdinateData = yy;
                    pp.AbscissaData = xx;
                    plotOrdIdent.Add(pp);
                    //NPlot.FilledRegion fr = new FilledRegion(
                    //    new VerticalLine(this.orders_ident.Data[0][i] - 2), new VerticalLine(this.orders_ident.Data[0][i] + 2));
                    //fr.Brush = Brushes.Orange;
                    //plotOrdIdent.Add(fr);
                }
            }

            plotOrdIdent.XAxis1.Label = "Pixel Number";
            plotOrdIdent.YAxis1.Label = "Flux";
            plotOrdIdent.AddInteraction(new NPlot.Windows.PlotSurface2D.Interactions.HorizontalDrag());
            plotOrdIdent.AddInteraction(new NPlot.Windows.PlotSurface2D.Interactions.VerticalDrag());
            plotOrdIdent.AddInteraction(new NPlot.Windows.PlotSurface2D.Interactions.AxisDrag(true));
            plotOrdIdent.Refresh();
        }

        /*********************************** Tracing **************************************/

        Orders trace_orders = null;
        Orders trace_orders_fit = null;
        Orders trace_minima = null;
        Orders trace_minima_fit = null;

        private void btnTracing_LoadData_Click(object sender, EventArgs e)
        {
            try
            {
                this.trace_orders = new Orders(this.pathToFolder + @"\trace.txt");
                this.trace_orders_fit = new Orders(this.pathToFolder + @"\orders_impoved.dat");
                this.trace_minima = new Orders(this.pathToFolder + @"\trace_min.txt");
                this.trace_minima_fit = new Orders(this.pathToFolder + @"\mins_improved.dat");
            }
            catch
            {
                MessageBox.Show("Some of data files were not been found or they have incorrect structure...", "Error...");
                return;
            }
        }

        private void btnTracing_Refresh_Click(object sender, EventArgs e)
        {
            int ord1, ord2;
            try
            {
                ord1 = int.Parse(txtTracing_Ord1.Text);
                ord2 = int.Parse(txtTracing_Ord2.Text);
            }
            catch
            {
                return;
            }

            if (this.trace_orders == null || this.trace_minima == null ||
                this.trace_minima_fit == null || this.trace_orders_fit == null) return;
            if (ord2 < ord1) return;
            if (ord1 < 0) ord1 = 0;
            if (ord2 > trace_orders.OrdersCount - 1) ord2 = trace_orders.OrdersCount - 1;

            plotTracing.Clear();
            if (cbTracing_OrdersTracing.Checked)
            {
                for (int i = ord1; i <= ord2; i++)
                {
                    PointPlot pp = new PointPlot(new Marker(Marker.MarkerType.Cross1, 2, Color.Red));
                    pp.AbscissaData = trace_orders.Pixels;
                    pp.OrdinateData = trace_orders.Fluxes[i];
                    plotTracing.Add(pp);
                }
            }

            if (cbTrcing_MinimaTracing.Checked)
            {
                for (int i = ord1; i <= ord2 + 1; i++)
                {
                    PointPlot pp = new PointPlot(new Marker(Marker.MarkerType.Cross1, 2, Color.Blue));
                    pp.AbscissaData = trace_minima.Pixels;
                    pp.OrdinateData = trace_minima.Fluxes[i];
                    plotTracing.Add(pp);
                }
            }

            if (cbTracing_OrdersFitting.Checked)
            {
                for (int i = ord1; i <= ord2; i++)
                {
                    LinePlot lp = new LinePlot();
                    lp.AbscissaData = trace_orders_fit.Pixels;
                    lp.OrdinateData = trace_orders_fit.Fluxes[i];
                    lp.Pen = new Pen(Brushes.Black, 2);
                    plotTracing.Add(lp);
                }
            }

            if (cbTracing_MinimaFitting.Checked)
            {
                for (int i = ord1; i <= ord2 + 1; i++)
                {
                    LinePlot lp = new LinePlot();
                    lp.AbscissaData = trace_minima_fit.Pixels;
                    lp.OrdinateData = trace_minima_fit.Fluxes[i];
                    lp.Pen = new Pen(Brushes.Brown, 2);
                    plotTracing.Add(lp);
                }
            }

            plotTracing.YAxis1.Reversed = true;
            plotTracing.XAxis1.Label = "Pixel X";
            plotTracing.YAxis1.Label = "Pixel Y";
            plotTracing.AddInteraction(new NPlot.Windows.PlotSurface2D.Interactions.HorizontalDrag());
            plotTracing.AddInteraction(new NPlot.Windows.PlotSurface2D.Interactions.VerticalDrag());
            plotTracing.AddInteraction(new NPlot.Windows.PlotSurface2D.Interactions.AxisDrag(true));
            //plotTracing.AddInteraction(new NPlot.Windows.PlotSurface2D.Interactions.RubberBandSelection());
            plotTracing.Refresh();
        }

        
        private void btnOrdIdentClear_Click(object sender, EventArgs e)
        {
            plotOrdIdent.Clear();
            plotOrdIdent.Refresh();
        }

        /****************************Wavelength Calibration*********************************/
        
        Orders thar_orders = null;
        Orders thar_lambdas = null;
        Repers thar_repers = null;
        private void btnRepers_Click(object sender, EventArgs e)
        {
            this.thar_orders = new Orders(this.pathToFolder + @"\thar_extacted.txt");
            this.thar_lambdas = new Orders(this.pathToFolder + @"\lambdas.dat");
            this.thar_repers = new Repers(this.pathToFolder + @"\found_repers.dat");
            lbOrders.Items.Clear();
            for (int i = 1; i <= this.thar_orders.OrdersCount; i++)
            {
                lbOrders.Items.Add("order # " + i.ToString());
            }

            lbOrders.SelectedIndexChanged+=new EventHandler(lbOrders_SelectedIndexChanged);
            plotWL.DoubleClick+=new EventHandler(plotWL_DoubleClick);
        }

        private void plotWL_DoubleClick(object sender, EventArgs e)
        {
            MouseEventArgs eA = (MouseEventArgs)e;
            Point here = new Point(eA.X, eA.Y);
            double x = this.plotWL.PhysicalXAxis1Cache.PhysicalToWorld(here, true);
            double y = this.plotWL.PhysicalYAxis1Cache.PhysicalToWorld(here, true);
            int index = lbOrders.SelectedIndex;
            if(index==-1) return;

            if (rbDispCurve.Checked)
            {
                int i=thar_repers.FindLine(index, x, y);
                PointPlot pp = new PointPlot(new Marker(Marker.MarkerType.Cross2));
                pp.AbscissaData = new double[1] { thar_repers.pixels_ord[index][i] };
                pp.OrdinateData = new double[1] { thar_repers.lambda_ord[index][i] };
                plotWL.Add(pp);
                plotWL.Refresh();
                MessageBox.Show(string.Format("Pix = {0:0000.00}; Lambda = {1:0000.0000}", 
                    thar_repers.pixels_ord[index][i], thar_repers.lambda_ord[index][i]));
            }
            if (rbRepers.Checked)
            {
                int i = thar_repers.FindLine(index, x);
                VerticalLine vl = new VerticalLine(thar_repers.pixels_ord[index][i] , Color.Blue);
                plotWL.Add(vl);
                plotWL.Refresh();
                MessageBox.Show(string.Format("Pix = {0:0000.00}; Lambda = {1:0000.0000}",
                    thar_repers.pixels_ord[index][i], thar_repers.lambda_ord[index][i]));
            }
        }

        private void rbDeviations_CheckedChanged(object sender, EventArgs e)
        {
            this.PlotWLRefresh();
        }

        private void lbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PlotWLRefresh();
        }

        private void rbDispCurve_CheckedChanged(object sender, EventArgs e)
        {
            this.PlotWLRefresh();
        }

        private void rbRepers_CheckedChanged(object sender, EventArgs e)
        {
            this.PlotWLRefresh();
        }

        private void PlotWLRefresh()
        {
            int index = lbOrders.SelectedIndex;
            plotWL.Clear();
            if (rbRepers.Checked)
            {
                if (index == -1) return;
                LinePlot lp = new LinePlot(thar_orders.Fluxes[index], thar_orders.Pixels);
                plotWL.Add(lp);
                double[] pixs = this.thar_repers.pixels_ord[index];

                for (int i = 0; i < pixs.Length; i++)
                {
                    VerticalLine vl = new VerticalLine(pixs[i], Color.Red);
                    plotWL.Add(vl);
                }
                plotWL.YAxis1.Label = "Flux";
            }
            if (rbDispCurve.Checked)
            {
                if (index == -1) return;
                PointPlot pp = new PointPlot();
                pp.Marker = new Marker(Marker.MarkerType.FilledCircle, 3, Color.Black);
                pp.AbscissaData = thar_repers.pixels_ord[index];
                pp.OrdinateData = thar_repers.lambda_ord[index];
                plotWL.Add(pp);

                LinePlot lp = new LinePlot();
                lp.Color = Color.Red;
                lp.AbscissaData = thar_lambdas.Pixels;
                lp.OrdinateData = thar_lambdas.Fluxes[index];
                plotWL.Add(lp);
                plotWL.YAxis1.Label = "Lambda";
            }
            if (rbOrders.Checked)
            {
                if (index == -1) return;
                PointPlot pp = new PointPlot();
                pp.Marker = new Marker(Marker.MarkerType.FilledCircle, 3, Color.Black);
                int n = 0;
                for (int i = 0; i < thar_repers.diviat_ord.Length; i++) 
                    n += thar_repers.diviat_ord[i].Length;
                double[] orders = new double[n];
                double[] deviations = new double[n];
                int k = 0;
                for (int i = 0; i < thar_repers.diviat_ord.Length; i++)
                {
                    for (int j = 0; j < thar_repers.diviat_ord[i].Length; j++)
                    {
                        deviations[k] = thar_repers.diviat_ord[i][j];
                        orders[k] = i + 1;
                        k++;
                    }
                }
                pp.AbscissaData = orders;
                pp.OrdinateData = deviations;
                plotWL.Add(pp);
            }
            if (rbDeviations.Checked)
            {
                Random rnd = new Random();
                for (int i = 0; i < thar_repers.pixels_ord.Length; i++ )
                {
                    PointPlot pp = new PointPlot();
                    pp.Marker = new Marker(Marker.MarkerType.Circle, 3, 
                        Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)));
                    pp.AbscissaData = thar_repers.pixels_ord[i];
                    pp.OrdinateData = thar_repers.diviat_ord[i];
                    plotWL.Add(pp);
                }
                if (cbSelectOrder.Checked)
                {
                    PointPlot pp = new PointPlot();
                    pp.Marker = new Marker(Marker.MarkerType.Cross2, 10, Color.Black);
                    pp.AbscissaData = thar_repers.pixels_ord[index];
                    pp.OrdinateData = thar_repers.diviat_ord[index];
                    plotWL.Add(pp);
                }
                plotWL.YAxis1.Label = "Delta Lambda";
            }

            plotWL.XAxis1.Label = "Pixel Number";
            plotWL.AddInteraction(new NPlot.Windows.PlotSurface2D.Interactions.HorizontalDrag());
            plotWL.AddInteraction(new NPlot.Windows.PlotSurface2D.Interactions.VerticalDrag());
            plotWL.AddInteraction(new NPlot.Windows.PlotSurface2D.Interactions.AxisDrag(true));
            plotWL.Refresh();
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            string folder;
            folderBrowserDialog1.ShowDialog();
            folder = folderBrowserDialog1.SelectedPath;
            txtFolder.Text = folder;
            this.pathToFolder = folder;
        }

        /*********************************************************************************/

        Orders orders_flat;
        Orders orders_flat_norm;
        Orders orders_flat_fit;
        private void btnLoadFlatNormData_Click(object sender, EventArgs e)
        {
            this.orders_flat = new Orders(pathToFolder+ @"\Flat_Orders.dat");
            this.orders_flat_norm = new Orders(pathToFolder + @"\Flat_Orders_Norm.dat");
            this.orders_flat_fit = new Orders(pathToFolder + @"\Flat_Orders_Fit.dat");
            lbFlatOrders.Items.Clear();
            for (int i = 1; i <=this.orders_flat.OrdersCount; i++)
            {
                lbFlatOrders.Items.Add("order # " + i.ToString());
            }
            lbFlatOrders.SelectedIndexChanged+=new EventHandler(lbFlatOrders_SelectedIndexChanged);
        }

        private void lbFlatOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbFlatOrders.SelectedIndex;
            if (index == -1) return;
            if (!(cbFlatOrders.Checked || cbFlatOrdersFit.Checked || cbFlatNorm.Checked))
                return;
            plotFlatNorm.Clear();
            if (cbFlatOrders.Checked)
            {
                LinePlot lp = new LinePlot(orders_flat.Fluxes[index], orders_flat.Pixels);
                plotFlatNorm.Add(lp);
            }
            if (cbFlatOrdersFit.Checked)
            {
                LinePlot lp = new LinePlot(orders_flat_fit.Fluxes[index], orders_flat_fit.Pixels);
                lp.Color = Color.Red;
                plotFlatNorm.Add(lp);
            }
            if (cbFlatNorm.Checked)
            {
                LinePlot lp = new LinePlot(orders_flat_norm.Fluxes[index], orders_flat_norm.Pixels);
                plotFlatNorm.Add(lp);
            }

            plotFlatNorm.XAxis1.Label = "Pixel Number";
            plotFlatNorm.YAxis1.Label = "Flux";
            plotFlatNorm.AddInteraction(new NPlot.Windows.PlotSurface2D.Interactions.HorizontalDrag());
            plotFlatNorm.AddInteraction(new NPlot.Windows.PlotSurface2D.Interactions.VerticalDrag());
            plotFlatNorm.AddInteraction(new NPlot.Windows.PlotSurface2D.Interactions.AxisDrag(true));
            //plotFlatNorm.AddInteraction(new NPlot.Windows.PlotSurface2D.Interactions.RubberBandSelection());
            plotFlatNorm.Refresh();
        }
    }
}
