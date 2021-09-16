let customerId = parseInt(sessionStorage.getItem('customerId'));
const cartItems = document.querySelector(".cart-items")
const orderUrl = 'api/order'


function AddToCart(e) {
  let selectedproductId = parseInt(e.target.dataset.id)
  sessionStorage.setItem('productId', selectedproductId)
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
    .then(data => {
      console.log(data);
        debugger
        sessionStorage.setItem('orderId', data)
      }  
    )
}