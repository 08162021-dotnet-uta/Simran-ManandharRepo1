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
              <h3><span onClick=ClickStore(event) data-id="${e.storeId}">${e.name}</span></h3>
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
              <div class = "product" data-set="${e.productId}" onClick=AddToCart(event)>  
                <h3><span class="name">${e.name}</span> - $<span class="price">${e.price}</span></h3>
                <button>Add To Cart</button>
            </div>
            `
          }) 
        })
}

// <img src="${e.picture}" alt="product" class="product-img">
//<img onClick=ClickStore(event) data-id="${e.storeId}" src="${e.picture}" alt="store" class="store-img">
