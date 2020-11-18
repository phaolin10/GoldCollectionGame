using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DosyaYaz : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    static string dosya = "data.txt";
    static string yol = Path.Combine(Environment.CurrentDirectory, dosya);


    // Write file using StreamWriter 
    public DosyaYaz()
    {

    }

    public static void writeToFile(string pathToWrite)
    {


        if (!File.Exists(yol))
        {
            var Dosya = File.Create(yol);
            Dosya.Close();
        }


        using (var writer = new StreamWriter(yol, true))
        {
            writer.WriteLine(pathToWrite);
        }
    }

    internal static void clearFile()
    {
        if (File.Exists(yol))
        {
            using (var writer = new StreamWriter(yol))
            {

                writer.WriteLine("");

            }
        }

    }




    // Update is called once per frame
    void Update()
    {

    }
}

