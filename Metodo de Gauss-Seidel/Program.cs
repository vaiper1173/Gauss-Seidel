using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_de_Gauss_Seidel
{
    class Program
    {
        
      
        public static void Main(string[] args)
        {

            int eleccion = 0, ite = 0, t = 0, v = 0;

            double error1 = 100, error2 = 100, error3 = 100,sumoerror = 100;

            double 
                a, s, d,
                f, g, h,
                j, k, l,
                aa,ss,dd,
                ff,gg,hh,
                jj,kk,ll;

            double 
                x, y, z,
                r1,r2,r3,
                rr1,rr2,rr3,
                p1 = 0,p2 = 0,p3 = 0;

            Console.WriteLine("por favor introdusca los valores iniciales de la primera ecuacion (X1)");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("por favor introdusca los valores iniciales de la segunda ecuacion (X2)");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("por favor introdusca los valores iniciales de la tercera ecuacion (X3)");
            z = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("porfavor introdusca los elementos de la matriz por medio de enters (esto corresponde a los coeficientes de las ecuaciones)");
            
            Console.WriteLine("introdusca 0,0");
            a = Convert.ToDouble(Console.ReadLine());
            aa = a;
            Console.WriteLine("introdusca 0,1");
            s = Convert.ToDouble(Console.ReadLine());
            ss = s;
            Console.WriteLine("introdusca 0,2");
            d = Convert.ToDouble(Console.ReadLine());
            dd = d;
            Console.WriteLine("introdusca 1,0");
            f = Convert.ToDouble(Console.ReadLine());
            ff = f;
            Console.WriteLine("introdusca 1,1");
            g = Convert.ToDouble(Console.ReadLine());
            gg = g;
            Console.WriteLine("introdusca 1,2");
            h = Convert.ToDouble(Console.ReadLine());
            hh = h;
            Console.WriteLine("introdusca 2,0");
            j = Convert.ToDouble(Console.ReadLine());
            jj = j;
            Console.WriteLine("introdusca 2,1");
            k = Convert.ToDouble(Console.ReadLine());
            kk = k;
            Console.WriteLine("introdusca 2,2");
            l = Convert.ToDouble(Console.ReadLine());
            ll = l;

            Console.WriteLine("por favor escriba las respuestas para la ecuaciones correspondientes");
            Console.WriteLine("respuesta de la primera ecuacion");
            r1 = Convert.ToDouble(Console.ReadLine());
            rr1 = r1;

            Console.WriteLine("respuesta de la segunda ecuacion");
            r2 = Convert.ToDouble(Console.ReadLine());
            rr2 = r2;

            Console.WriteLine("respuesta de la tercera ecuacion");
            r3 = Convert.ToDouble(Console.ReadLine());
            rr3 = r3;


            if (a < f)
            {

                //segunda fila igual a primera fila 
                a = f;
                s = g;
                d = h;
                r1 = r2;
                //primera fila igual a segunda fila
                f = aa;
                g = ss;
                h = dd;
                r2 = rr2;
            }


            if (h > l)
            {
                //segunda fila igual a tercera fila
                j = f;
                k = g;
                l = h;
                r3 = r2;
                
                //tercera fila igual a segunda fila 
                f = jj;
                g = kk;
                h = ll;
                r2 = rr3;
            }

            Console.WriteLine(a + " " + s + " " + d + " | " + r1);
            Console.WriteLine(f + " " + g + " " + h + " | " + r2);
            Console.WriteLine(j + " " + k + " " + l + " | " + r3);
            Console.WriteLine("con valores iniciales de " + "X1 = " + x +",X2 = " + y + ",X3 = " + z);

            Console.WriteLine("Por Favor elija el metodo de iteracion que quiera, 1 para limite de iteracion, 2 para porsentaje de error");
            eleccion = Convert.ToInt16(Console.ReadLine());

            switch (eleccion)
            {
                case 1:
                    Console.WriteLine("Usted a elegido por iteracion, por favor introdusca la cantidad de iteraciones que deseé");
                    t = Convert.ToInt16(Console.ReadLine());

                    while (t > ite)
                    {

                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("iteracion " + ite);
                        Console.WriteLine("el valor de X1 es de aproximadamente " + x);
                        Console.WriteLine("el error aproximado es de  " + error1);
                        Console.WriteLine("el valor de X2 es de aproximadamente " + y);
                        Console.WriteLine("el error aproximado es de  " + error2);
                        Console.WriteLine("el valor de X3 es de aproximadamente " + z);
                        Console.WriteLine("el error aproximado es de  " + error3);

                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");

                        x = ((-s * y) + (-d * z) + r1) / a;
                        Console.WriteLine(x);
                        y = ((-f * x) + (-h * z) + r2) / g;
                        Console.WriteLine(x);
                        z = ((-j * x) + (-k * y) + r3) / l;
                        Console.WriteLine(x);
                        
                        error1 = ((x - p1) / x) * 100;
                        if (error1 < 0)
                        {
                            error1 = error1 * -1;
                        }
                        error2 = ((y - p2) / y) * 100;
                        if (error2 < 0)
                        {
                            error2 = error2 * -1;
                        }
                        error3 = ((z - p3) / z) * 100;
                        if (error3 < 0)
                        {
                            error3 = error3 * -1;
                        }

                        p1 = x;
                        p2 = y;
                        p3 = z;

                        
                        ite++;
                        v += ite;
                    }

                    break;

                case 2:

                    Console.WriteLine("Usted a elegido por limite de error, por favor introdusca la cantidad de iteraciones que deseé");
                    sumoerror = Convert.ToDouble(Console.ReadLine());

                    while(error1 < sumoerror | error2 < sumoerror | error3 < sumoerror)
                        Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");

                        x = ((-s * y) + (-d * z)+ r1) / a;
                        Console.WriteLine(x);
                        y = ((-f * x) + (-g * z)+ r2) / h;
                        Console.WriteLine(x);
                        z = ((-j * x) + (-k * y)+ r3) / l;
                        Console.WriteLine(x);
                        error1 = ((x - p1) / x) * 100;
                        if (error1 < 0)
                        {
                            error1 = error1 * -1;
                        }
                        error2 = ((y - p2) / y) * 100;
                        if (error2 < 0)
                        {
                            error2 = error2 * -1;
                        }
                        error3 = ((z - p3) / z) * 100;
                        if (error3 < 0)
                        {
                            error3 = error3 * -1;
                        }

                        p1 = x;
                        p2 = y;
                        p3 = z;

                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("iteracion " + ite);
                        Console.WriteLine("el valor de X1 es de aproximadamente " + x);
                        Console.WriteLine("el error aproximado es de  " + error1);
                        Console.WriteLine("el valor de X2 es de aproximadamente " + y);
                        Console.WriteLine("el error aproximado es de  " + error2);
                        Console.WriteLine("el valor de X3 es de aproximadamente " + z);
                        Console.WriteLine("el error aproximado es de  " + error3);
                        
                        ite++;
                        v += ite;

                    break;
            }



            Console.ReadKey();

        }
    }
}
