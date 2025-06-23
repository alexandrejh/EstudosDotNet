class Product {
  constructor(name, price, quantity) {
    this.name = name;
    this.price = price;
    this.quantity = quantity;
  }

  toString() {
    return `${this.name}, $${this.price.toFixed(2)}, ${this.quantity}`;
  }

  //com OO

  total() {
    return this.price * this.quantity;
  }

  updatePrice(percentage) {
    this.price = this.price * (1 + percentage / 100);
  }

  //fim com OO
}

//sem OO

function total(product) {
  return product.price * product.quantity;
}

function updatePrice(product, percentage) {
  product.price = product.price * (1 + percentage / 100);
}

//fim sem OO

const p1 = new Product("Laptop", 1000.0, 5);
const p2 = new Product("Headphones", 200.0, 2);

p1.updatePrice(10);

console.log(p1.total());