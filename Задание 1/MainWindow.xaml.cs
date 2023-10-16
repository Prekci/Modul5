using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace Задание_1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private Random random = new Random();
        // Генерирует случайное дробное число в заданном диапазоне
        private double GetRandomDouble(double minValue, double maxValue)
        {
            return random.NextDouble() * (maxValue - minValue) + minValue;
        }
        // Генерирует случайное целое число в заданном диапазоне.
        private int GetRandomInt(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue + 1);
        }

        private void Линия_Click(object sender, RoutedEventArgs e)
        {
            // Генерация случайных координат для начала и конца линии.
            double x1 = GetRandomDouble(0, 680);
            double y1 = GetRandomDouble(0, 390);
            double x2 = GetRandomDouble(0, 680);
            double y2 = GetRandomDouble(0, 390);
            Line line = new Line
            {
                X1 = x1,
                Y1 = y1,
                X2 = x2,
                Y2 = y2,
                Stroke = Brushes.LightBlue,
                StrokeThickness = GetRandomDouble(1, 5)
            };
            // Проверка, чтобы убедиться, что линия находится в пределах Canvas
            if (x1 + line.StrokeThickness > Холст.ActualWidth)
                x1 = Холст.ActualWidth - line.StrokeThickness;
            if (y1 + line.StrokeThickness > Холст.ActualHeight)
                y1 = Холст.ActualHeight - line.StrokeThickness;
            if (x2 + line.StrokeThickness > Холст.ActualWidth)
                x2 = Холст.ActualWidth - line.StrokeThickness;
            if (y2 + line.StrokeThickness > Холст.ActualHeight)
                y2 = Холст.ActualHeight - line.StrokeThickness;
            Canvas.SetLeft(line, x1);
            Canvas.SetTop(line, y1);
            // Добавление линии на холст.
            Холст.Children.Add(line);
        }
        private void Квадрат_Click_1(object sender, RoutedEventArgs e)
        {
            // Генерация случайных размеров и координат для квадрата.
            double width = GetRandomDouble(10, 200);
            double height = GetRandomDouble(10, 200);
            Rectangle rect = new Rectangle
            {
                Width = width,
                Height = height,
                Stroke = Brushes.LightGreen,
                StrokeThickness = GetRandomDouble(1, 5)
            };
            // Проверка, чтобы убедиться, что прямоугольник находится в пределах Canvas
            if (width + rect.StrokeThickness > Холст.ActualWidth)
                width = Холст.ActualWidth - rect.StrokeThickness;
            if (height + rect.StrokeThickness > Холст.ActualHeight)
                height = Холст.ActualHeight - rect.StrokeThickness;
            Canvas.SetLeft(rect, GetRandomDouble(0, Холст.ActualWidth - width));
            Canvas.SetTop(rect, GetRandomDouble(0, Холст.ActualHeight - height));
            // Добавление прямоугольника на холст.
            Холст.Children.Add(rect);
        }
        private void Круг_Click_(object sender, RoutedEventArgs e)
        {
            // Генерация случайного радиуса и координат для круга.
            double radius = GetRandomDouble(10, 200);
            Ellipse ellipse = new Ellipse
            {
                Width = radius,
                Height = radius,
                Stroke = Brushes.LightPink,
                StrokeThickness = GetRandomDouble(1, 5)
            };
            // Проверка, чтобы убедиться, что круг находится в пределах Canvas
            if (radius + ellipse.StrokeThickness > Холст.ActualWidth)
                radius = Холст.ActualWidth - ellipse.StrokeThickness;
            if (radius + ellipse.StrokeThickness > Холст.ActualHeight)
                radius = Холст.ActualHeight - ellipse.StrokeThickness;
            Canvas.SetLeft(ellipse, GetRandomDouble(0, Холст.ActualWidth - radius));
            Canvas.SetTop(ellipse, GetRandomDouble(0, Холст.ActualHeight - radius));
            // Добавление круга на холст.
            Холст.Children.Add(ellipse);
        }
        private void Очистить_Click_3(object sender, RoutedEventArgs e)
        {
            // Удаление всех элементов с холста.
            Холст.Children.Clear();
        }
    }
}
