using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptList : MonoBehaviour
{
    public class List : MonoBehaviour
    {
        [System.Serializable]
        public class Orc
        {
            public string nome;
            public int forca;
            public int dano;
        }

        public List<string> Inimigos = new List<string>();

        public List<Orc> Orcs = new List<Orc>();

        void Start()
        {
            Inimigos.Add("Orc");
            Inimigos.Add("Elfo");
            Inimigos.Add("Guerreiro");
            Inimigos.Add("Arqueiro");

            Orc orc1 = new Orc();
            orc1.nome = "Mato";
            orc1.forca = 70;
            orc1.dano = 100;

            Orc orc2 = new Orc();
            orc2.nome = "Matios";
            orc2.forca = 10;
            orc2.dano = 20;

            Orcs.Add(orc2);
            Orcs.Add(orc1);

            Orcs.Remove(orc2);
        }

        // Update is called once per frame
        void Update()
        {

        }

    }
}
