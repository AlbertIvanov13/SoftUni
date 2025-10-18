using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingShape_Before.Interfaces
{
    public interface IRenderer
    {
        void Render(IDrawingContext context, IShape shape);
    }
}