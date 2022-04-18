namespace laba1
{
    public partial class Form1 : Form
    {
        private List<Figure> figures;
        private List<Painter> painters;
        private const int FigAll = 7;
        private Graphics painter;
        private int currFigNum = 0;
        PointF[] Clicks = new PointF[3];

        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            painter = pictureBox1.CreateGraphics();

            figures = new List<Figure>()
            {   
                new Point(new PointF(25,25)),
                new Ellipse(new PointF(0,0), 40, 25),
                new Circle(new PointF(0,0), 40),
                new Line(new PointF(0,0)),
                new Triangle(new PointF(0,0)),
                new RightTriangle(new PointF(0,0)),
                new Rectangle(100,100)
            };

            painters = new List<Painter>()
            {
                new PointPainter(new PointF(25,25)),
                new EllipsePainter(new PointF(0,0), 40, 25),
                new CirclePainter(new PointF(0,0), 40),
                new LinePainter(new PointF(0,0)),
                new TrianglePainter(new PointF(0,0)),
                new RightTrianglePainter(new PointF(0,0)),
                new RectanglePainter(100,100)
            };
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int currfig = 0;
            currfig = comboBox1.FindString(comboBox1.SelectedItem.ToString());
            PointF ClickCords1 = new PointF(e.X, e.Y);
            MessageBox.Show(ClickCords1.ToString());



        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
            PointF ClickCords1 = new PointF(e.X, e.Y);
            MessageBox.Show(ClickCords1.ToString());
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            int currfig = 0;
            PointF ClickCords = new PointF(e.X, e.Y);
            
            currfig = comboBox1.FindString(comboBox1.SelectedItem.ToString());
            figures[currfig].PointStart = ClickCords;
            painters[currfig].Pointst = figures[currfig].PointStart;
            painters[currfig].Draw(painter);
                
                  
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int currfig = 0;
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            currfig = comboBox1.FindString(comboBox1.SelectedItem.ToString());
            painters[currfig].BorderColor = colorDialog1.Color;
            painters[currfig].FillColor = colorDialog1.Color;
        }
    }
}