using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Croaziera;

public partial class FormAdministrare : Form
{
    private List<Point> Coordonate;
    private List<string> numePorturi =
    [
        "Constanta",
        "Varna",
        "Burgas",
        "Istambul",
        "Kozlu",
        "Samsun",
        "Batumi",
        "Sokhumi",
        "Soci",
        "Anapa",
        "Yalta",
        "Sevastopol",
        "Odessa"
    ];
    private List<Port> Porturi;
    private const int NumarTotalPorturi = 13;
    public FormAdministrare()
    {
        InitializeComponent();
    }

    private void buttonListaCroaziere_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormListaCroaziere formCroaziere = new FormListaCroaziere();
        formCroaziere.Show();
    }

    private void buttonInitCoordonate_Click(object sender, EventArgs e)
    {
        Coordonate = new List<Point>();
        MessageBox.Show("Da cate un click pe fiecare port, incepand din Constanta si terminand cu Odessa", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);

    }

    private void pictureBoxMareaNeagra_MouseClick(object sender, MouseEventArgs e)
    {
        Coordonate.Add(e.Location);
        bool esteUltimul = Coordonate.Count == NumarTotalPorturi;
        string nrPunct = esteUltimul ? "ultimul punct" : $"punctul nr. {Coordonate.Count}";
        updateProgress(Coordonate.Count, NumarTotalPorturi);
    }

    private void updateProgress(int count, int numarTotalPorturi)
    {
        throw new NotImplementedException();
    }

    private void buttonSaveCoordonate_Click(object sender, EventArgs e)
    {
        if(Coordonate.Count != NumarTotalPorturi)
        {
            return;
        }
        Porturi = [];

        for(int i = 0; i < NumarTotalPorturi; i++)
        {
            var port = new Port(i + 1, numePorturi[i], Coordonate[i]);
            Porturi.Add(port);
        }
        salveazaPorturiInDB(Porturi);
    }

    private void salveazaPorturiInDB(List<Port> porturi)
    {
        MessageBox.Show(Directory.GetCurrentDirectory(), "Folder curent");
        string folderDb = "C:\\Users\\rares\\source\\repos\\Subiecte-CSharp\\2015\\Croaziera\\Croaziera";
        string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={folderDb}\\CroazieraDB.mdf;Integrated Security=True";
    }
}

public class Port
{
    public Port(int id, string nume, Point pozitie)
    {
        Id = id;
        Nume = nume;
        Pozitie = pozitie;
    }

    int Id { get; }
    string Nume { get; }

    Point Pozitie { get; }
}
