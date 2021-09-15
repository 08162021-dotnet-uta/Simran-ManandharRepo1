const uri = 'api/customer'
const form = document.getElementById("login-form")
const inputFields = document.querySelectorAll(".input-text")
const loginCustomer = document.querySelector(".login")
const registerCustomer = document.querySelector(".register")


form.addEventListener('submit', (e)=>{
  e.preventDefault()
  form.style.display="none"
  if (e.submitter.value === "Register") {
    fetch(uri, {
        method: "POST",
        headers: {
            "Content-Type": "application/json",
            Accept: "application/json"
        },
        body: JSON.stringify({
            Name: inputFields[0].value,
            Email: inputFields[1].value
        })
    })
  } else {
        fetch(`${uri}/${inputFields[0].value}&${inputFields[1].value}`)
          .then(res => {
            if (!res.ok) {
              console.log("Enable to login")
              throw new Error(`Network response was not ok(${res.status})`)
            }
            return res.json()
          })
            .then(data => {
              console.log(data)
              sessionStorage.setItem('customerId', JSON.stringify(data))
            })
          .catch(err => {
        console.log(`The error was ${err}`)
      })
    }
})