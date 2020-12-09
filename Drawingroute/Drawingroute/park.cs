using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawingroute
{
    public class park
    {

        IList<attraction> attractions;
        public park()
        {
            attractions = new List<attraction>();
            //random values om het even te testen.
            /* misschien beter om de variabele "destination" in de klasse path te veranderen naar een string
             ofzo, want op dit moment is er vgm geen andere manier dan opnieuw de list door te gaan om te kijken
            om de paths van iedere attractie in een list te vullen*/
            attractions.Add(new attraction(new Point(100, 100), "kaas", 4, 4));
            attractions.Add(new attraction(new Point(100, 300), "koos", 4, 4));


            foreach (attraction attraction in attractions)
            {
                if(attraction.Name == "kaas")
                {
                    foreach(attraction attractie in attractions)
                    {
                        if (attractie.Name == "koos")
                        {
                            attraction.Paths.Add(new path(attractie, 1, 150, 200, 0, 0));
                        }
                    }
                }

                /*
                if(attraction.Name == "koos")
                {
                    foreach (attraction attractie in attractions)
                    {
                        if (attractie.Name == "kaas")
                        {
                            attraction.Paths.Add(new path(attractie, 1, 50, 100, 100, 100));
                        }
                    }
                }
                */
            }
        }

        public void Draw(Graphics gr, Brush br, Pen p)
        {
            foreach (attraction attraction in attractions)
            {
                //draws the location of each attraction as a black square.
                gr.FillRectangle(br, attraction.Locationattraction.X - 5, attraction.Locationattraction.Y - 5, 10, 10); 

                foreach (path path in attraction.Paths)
                {
                    //if the path is a straight line.
                    if (path.Location1.X == 0)
                    {
                        gr.DrawLine(p, attraction.Locationattraction, path.Destination.Locationattraction);
                    }

                    //if the path has 1 bend in it.
                    else if(path.Location1.X != 0 && path.Location2.X == 0)
                    {
                        gr.DrawLine(p, attraction.Locationattraction, path.Location1);
                        gr.DrawLine(p, path.Location1, path.Destination.Locationattraction);
                    }

                    //if the path has 2 bends in it.
                    else if(path.Location2.X != 0)
                    {
                        gr.DrawLine(p, attraction.Locationattraction, path.Location1);
                        gr.DrawLine(p, path.Location1, path.Location2);
                        gr.DrawLine(p, path.Location2, path.Destination.Locationattraction);
                    }
                }
            }
        }
    }
}
