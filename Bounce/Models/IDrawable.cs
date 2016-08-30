using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bounce.Models
{
    public interface IDrawable
    {
        void Draw(int x, int y, PictureBox box, Brush brush);
    }
}
