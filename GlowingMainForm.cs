using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Glowing
{
    public partial class GlowingMainForm : Form
    {
        private ICodeGenerator codeGenerator;
        public GlowingMainForm()
        {
            InitializeComponent();
            codeGenerator = new JsonGenerator();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CodeGenerationButton_Click(object sender, EventArgs e)
        {
            var jsonText = JsonTextBox.Text;
            var code = codeGenerator.GenerateCode(jsonText);
            CodeTextBox.Text = code;
        }
    }
}
