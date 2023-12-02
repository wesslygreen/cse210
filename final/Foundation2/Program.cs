using System;

class Program
{
    static void Main(string[] args)
    {
        //first address, customer, order
        Address zachAddress = new Address();
        zachAddress.setStreet("20 Roundview Street");
        zachAddress.setCity("Houston");
        zachAddress.setCountry("United States");
        zachAddress.setState("Texas");

        Customer zach = new Customer();
        zach.setName("Zach Bryant");
        zach.setAddress(zachAddress);

        Order zachOrder = new Order();
        zachOrder.setCustomer(zach);
        Product potatoes = new Product("Potatoes",1,4.99,1);
        Product butter = new Product("Butter",2,2.99,2);
        Product chicken = new Product("Chicken",3,10.99,1);
        zachOrder.addToOrder(potatoes);
        zachOrder.addToOrder(butter);
        zachOrder.addToOrder(chicken);

        Console.WriteLine("First Order - ");
        zachOrder.printPackingLabel();
        zachOrder.printShippingLabel();
        Console.WriteLine("Cost: $" + zachOrder.getOrderCost());

        // second address, customer and order
        Address marcosAddress = new Address();
        marcosAddress.setStreet("121 Calle Altavista");
        marcosAddress.setCity("Guatemala City");
        marcosAddress.setState("Guatemala");
        marcosAddress.setCountry("Guatemala");

        Customer marcos = new Customer();
        marcos.setName("Marcos Fuentes");
        marcos.setAddress(marcosAddress);

        Order marcosOrder = new Order();
        marcosOrder.setCustomer(marcos);
        Product beans = new Product("Beans",1,1.99,2);
        Product cereal = new Product("Cereal",2,2.99,1);
        Product batteries = new Product("Batteries",3,9.99,1);
        marcosOrder.addToList(beans);
        marcosOrder.addToList(cereal);
        marcosOrder.addToList(batteries);

        Console.WriteLine("\nSecond Order - ");
        marcosOrder.printPackingLabel();
        marcosOrder.printShippingLabel();
        Console.WriteLine("Cost: $" + marcosOrder.getOrderCost());
    }
}