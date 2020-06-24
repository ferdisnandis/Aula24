using System;
using System.Collections.Generic;

namespace Aula24
{
    public class Carrinho
    {
        //Guardar valor total
        public float ValorTotal { get; set; }

        //Lista do carrinho
        List<Produto> carrinho = new List<Produto>();
        //Adicionar ao carrinho, passando objeto como argumento
        public void AdicionarProduto(Produto produto){
            carrinho.Add(produto);
        }
        public void RemoverProduto(Produto produto){
            carrinho.Remove(produto);
        }
        //Listar o que está no carrinho
        public void MostrarProdutos(){
            if(carrinho !=null){
                foreach(Produto p in carrinho)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"R$ {p.Preco.ToString("n2")} - {p.Nome}");
                    Console.ResetColor();
                }
                MostrarTotal();
            }
        }
        //Calcular o total da compra
        public void MostrarTotal(){
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            if(carrinho != null){
                foreach(Produto p in carrinho){
                    ValorTotal += p.Preco;
            }
                    Console.WriteLine($"Total do Carrinho R$ {ValorTotal.ToString("n2")}");
            }else{
                Console.WriteLine($"Seu carrinho ainda está vazio!");
            }
            Console.ResetColor();
            }

        //Alterar um determinado produto
        public void AlterarItem(int _codigo, Produto _novoProduto){
            carrinho.Find(x => x.Codigo == _codigo).Nome = _novoProduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _novoProduto.Preco;
        }
        }
                
    }
