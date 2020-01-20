using System;

namespace QueueSimulator.Model
{
    class Fila<T>
    {
        // Primeiro nodo da fila
        public No<T> FirstNode { get; set; }
        // Último nodo da fila
        public No<T> LastNode { get; set; }
        // Quantidade de items na fila
        public int Count { get; set; }

        public Fila()
        {
            FirstNode = null;
            LastNode = null;
            Count = 0;
        }
        // Verifica se a fila esta vazia
        public bool EstaVazio
        {
            get
            {
                return FirstNode == null;
            }
        }
        
        // adiciona um item ao fim da fila
        public void Enqueue(T item)
        {
            lock(this){
                if (EstaVazio)
                {
                    FirstNode = LastNode = new No<T>(item);
                }
                else
                {
                    LastNode = LastNode.Next = new No<T>(item);
                    Count++;
                }
            }
        }
        // Retira o first item da fila
        public void Dequeue()
        {
            lock (this)
            {
                if (EstaVazio)
                {
                    throw new ArgumentException("Não é possível remover", "Fila vazia");
                }

                object DadoRemovido = FirstNode.Item;

                if (FirstNode.Equals(LastNode))
                {
                    FirstNode = null;
                    LastNode = null;
                }
                else
                {
                    FirstNode = FirstNode.Next;
                }
                Count--;
            }
        } 
        // Retorna o proximo item da fila a ser removido
        public T Peek()
        {
            return FirstNode.Item;
        }
        // Retorna a fila em um Array
        public T[] ToArray()
        {
            T[] arrayTemp = new T[Count + 1];

            int contador = 0;
            No<T> node = FirstNode;

            while (node != null)
            {
                arrayTemp[contador] = node.Item;
                contador++;
                node = node.Next;
            }
            return arrayTemp;
        }
            
    }
}
