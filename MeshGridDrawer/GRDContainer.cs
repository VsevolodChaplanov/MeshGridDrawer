using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeshGridDrawer
{
    class GRDContainer
    {
        // Число делений по осям x,y
        private uint Nx { set; get; }
        private uint Ny { set; get; }
        // Минимальное и максимальное значение по осям
        private double xMin { set; get; }
        private double xMax { set; get; }
        private double yMin { set; get; }
        private double yMax { set; get; }
        private double zMin { set; get; }
        private double zMax { set; get; }
        // Контейнер хранения значений функции
        private List<double> funcValues = new List<double>();

        public GRDContainer() { }
        public GRDContainer(uint Nx, uint Ny, 
                double xMin, double xMax, double yMin, double yMax,
                List<double> values)
        {
            this.Nx = Nx;
            this.Ny = Ny;
            this.xMax = xMax;
            this.xMin = xMin;
            this.yMax = yMax;
            this.yMin = yMin;
            this.funcValues = values;
        }

        public void setNx(uint Nx)
        {
            this.Nx = Nx;
        }
        public void setNy(uint Ny)
        {
            this.Ny = Ny;
        }
        public void setxMin(double xMin)
        {
            this.xMin = xMin;
        }
        public void setxMax(double xMax)
        {
            this.xMax = xMax;
        }
        public void setyMin(double yMin)
        {
            this.yMin = yMin;
        }
        public void setyMax(double yMax)
        {
            this.yMax = yMax;
        }
        public void setzMin(double zMin)
        {
            this.zMin = zMin;
        }
        public void setzMax(double zMax)
        {
            this.zMax = zMax;
        }
        public void Append(double value)
        {
            funcValues.Add(value);
        }
    }
}
