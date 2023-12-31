﻿namespace projetoGuardaChuva.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public int Cep { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public int IdSetor { get; set; }
        public string Coordenadas { get; set; }
        public double Altura { get; set; }
        public double Base { get; set; }
        public double AnguloInclinacao { get; set; }
        public double VolumeBacia { get; set; }
    }

    public class EnderecoOutput
    {
        public int Id { get; set; }
        public int Cep { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public int IdSetor { get; set; }
        public string NomeSetor { get; set; }
        public string Coordenadas { get; set; }
        public double VolumeBacia { get; set; }
    }

}
