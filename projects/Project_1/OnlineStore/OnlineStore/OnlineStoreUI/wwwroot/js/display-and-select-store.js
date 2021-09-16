const store = document.getElementById("stores")
const welcomeText = document.getElementById("welcome-text")


function selectStore() {
  welcomeText.style.display="none"
  fetch(`api/store`)
    .then(r => r.json())
    .then(json => {
      console.log(json)
      json.forEach(e => {
        store.innerHTML += `
              <article class = "store">
                <img onClick=ClickStore(event) data-id="${e.storeId}" src="${e.picture}" alt="store" class="store-img">
              </article>
            `
      })
    });
}

function ClickStore(event) {
  store.style.display = "none";
  let selectedStoreId = parseInt(event.target.dataset.id)
  fetch(`api/Product/storeid=${selectedStoreId}`)
        .then(r => r.json())
        .then(json => {
            json.forEach(e => {
                productList.innerHTML += `
              <article class = "product">
                    <img src="${e.picture}" alt="product" class="product-img">
                <h3>${e.name} - $${e.price} <span data-id="${e.productId}" onClick=AddToCart(event)>Add to cart</span></h3>
                <h2></h2>
            </article>
            `
          }) 
        })
}