using Devs2Blu.ProjetosAula.SistemaDeClinica.Models.Model;
using System;
using System.Collections.Generic;

namespace Devs2Blu.ProjetosAula.SistemaDeClinica.Main.Utils
{
    public class Mocks
    {
        public List<Paciente> ListaPacientes { get; set; }
        public List<Medico> ListaMedicos { get; set; }
        public List<Recepcionista> ListaRecepcionistas { get; set; }
        public List<Fornecedor> ListaFornecedores { get; set; }
        public Random Random { get; set; }

        public Mocks()
        {
            ListaPacientes = new List<Paciente>();
            ListaMedicos = new List<Medico>();
            ListaRecepcionistas = new List<Recepcionista>();
            ListaFornecedores = new List<Fornecedor>();

            Random = new Random();

            CargaMock();
        }

        public void CargaMock()
        {
            CargaPaciente();
            CargaMedico();
            CargaRecepcionista();
            CargaFornecedor();
        }

        public void CargaPaciente()
        {
            for (int i = 0; i < 10; i++)
            {
                Paciente paciente = new Paciente(i, $"Paciente {i}", $"{i}23{i}56{i}891{i}", "Unimed");
                ListaPacientes.Add(paciente);
            }
        }

        public void CargaMedico()
        {
            string[] especialidades = { "Cirurgião", "Cardiologista", "Dermatologista", "Endocrinologista", "Gastroenterologista" };
            for (int i = 0; i < 10; i++)
            {
                Medico medico = new Medico(i, $"Médico {i}", $"{i}23{i}56{i}891{i}", Random.Next(1, 999), especialidades[Random.Next(0, especialidades.Length - 1)]);
                ListaMedicos.Add(medico);
            }
        }

        public void CargaRecepcionista()
        {
            for (int i = 0; i < 10; i++)
            {
                Recepcionista recepcionista = new Recepcionista(i, $"Recepcionista {i}", $"{i}23{i}56{i}891{i}", $"Setor {i}");
                ListaRecepcionistas.Add(recepcionista);
            }
        }

        public void CargaFornecedor()
        {
            for (int i = 0; i < 10; i++)
            {
                Fornecedor fornecedor = new Fornecedor(i, $"Fornecedor {i}", $"{i}23{i}56{i}891{i}", "Tipo Fornecedor");
                ListaFornecedores.Add(fornecedor);
            }
        }
    }
}
