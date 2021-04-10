using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio6
{
    class Producto
    {

        //Atributos
        private string descripcion;
        private string codigo;
        private int puntoPedido;
        private int maxStockPer;
        private int stockProd;
        private double precioUni;

        //Costructores
        public Producto()
        {
            this.descripcion = "No se ingresó stock";
            this.codigo = " ";
            this.puntoPedido = 0;
            this.maxStockPer = 0;
            this.stockProd = 0;
            this.precioUni = 0;
        }

        public Producto(string descripcion, string codigo, int pedido, int maxStock, int stock, double precio)
        {
            this.descripcion = descripcion;
            this.codigo = codigo;
            this.puntoPedido = pedido;
            this.maxStockPer = maxStock;
            this.stockProd = stock;
            this.precioUni = precio;
        }

        //Geters Seters
        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public void setCodigo(string codigo)
        {
            this.codigo = codigo;
        }

        public void setPuntoPedido(int pedido)
        {
            this.puntoPedido = pedido;
        }

        public void setMaximoStock(int stockMax)
        {
            this.maxStockPer = stockMax;
        }

        public void setStock(int stock)
        {
            this.stockProd = stock;
        }

        public void setPrecio(double precio)
        {
            this.precioUni = precio;
        }

        public string getDescripcion()
        {
            return this.descripcion;
        }

        public string getCodigo()
        {
            return this.codigo;
        }

        public int getPuntoPedido()
        {
            return this.puntoPedido;
        }

        public int getMaximoStock()
        {
            return this.maxStockPer;
        }

        public int getStock()
        {
            return this.stockProd;
        }

        public double getPrecio()
        {
            return this.precioUni;
        }

        //Metodo que controla las ventas e informa stock
        public void Vender(int cantProd)
        {
            //este bloque de codigo permite realizar las ventas si hay stock disponible
            if ((getStock() >= 1) && (getStock() <= getMaximoStock()))
            {
                this.stockProd -= cantProd;

                Console.WriteLine("Cantidad\t\tProducto\t\tPrecio Unitario\t\tTotal");
                Console.WriteLine($"{cantProd}\t\t{getDescripcion()}\t\t{getPrecio()}\t\t{getPrecio() * cantProd}");
            }
            else
            {
                Console.WriteLine("No se puede realizar la venta");
            }

            //si el stock se esta acabando informa que se debe realizar una compra
            if (getStock() == 0)
            {
                Console.WriteLine($"producto sin stock");
            }
            else if (getStock() < getPuntoPedido())
            {
                Console.WriteLine($"El stock se esta acabando, quedan {getStock()} unidades. Realize una compra del producto");
            }
        }

        //controla la compra de stock
        public void Comprar(int cantProd)
        {
            //si la compra supera el maximo permitido se informara en caso contrario se realizara la compra
            if ((cantProd + getStock()) > getMaximoStock())
            {
                Console.WriteLine($"La compra supera el maximo de {getMaximoStock()} unidades permitidas");
            }
            else
            {
                this.stockProd += cantProd;
                Console.WriteLine($"La compra se ah realizado con exito, Usted dispone de {getStock()}");
            }
        }

        public void ConsultaStock()
        {
            if (getStock() != 0)
            {
                Console.WriteLine($"Producto: {getCodigo()}\t {getDescripcion()}\nStock: {getStock()}\nPrecio unitario: {getPrecio()}\n Precio total: {getPrecio() * getStock()}");
            }
            else
            {
                Console.WriteLine($"El producto {getCodigo()}\t {getDescripcion()} esta sin stock");
            }
        }
    }
}