const cartItems = document.getElementById("cart-items")
const orderUrl = 'api/order'
const productOrderUrl = 'api/productorder'
const cartBlock = document.getElementById("cart-block")
const totalBlock = document.getElementById("total-block")
const priceBlock = document.getElementById("price-block")
let totalPrice = 0;
let productIdArray = []

function AddToCart(e) {
  let customerId = parseInt(sessionStorage.getItem('customerId'));
  let selectedproductId = parseInt(e.target.dataset.id)
  productIdArray.push(selectedproductId)
  let productName = e.path[1].childNodes[1].childNodes[0].innerText
  let productPrice= parseInt(e.path[1].childNodes[1].childNodes[2].innerText)

  sessionStorage.setItem('productId', selectedproductId)
  sessionStorage.setItem('ProductName', productName)
  sessionStorage.setItem('ProductPrice', productPrice)

  // debugger
  fetch(orderUrl, {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
      Accept: "application/json"
    },
    body: JSON.stringify({
      CustomerId: customerId
    })
  })
    .then(res => res.json())
    .then(data => {
      console.log(data)
    }) // need to reset this???
  //     sessionStorage.setItem('orderId', data)
  totalPrice += productPrice;
  cartBlock.style.display="block"
  cartItems.innerHTML += `
    <h4>${productName} - $${productPrice}</h4>
  `
  totalBlock.style.display="block"
  priceBlock.innerHTML = `$${totalPrice}
  `
//if checkout
  // fetch(productOrderUrl, {
  //   method: "POST",
  //   headers: {
  //     "Content-Type": "application/json",
  //     Accept: "application/json"
  //   },
  //   body: JSON.stringify({
  //     ProductId: selectedproductId,
  //     OrderId: orderId
  //   })
  // })

      
}

