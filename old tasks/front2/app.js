function getCountries(link)
{
    return fetch(link)
        // .then(res=>res.json())
        .then(res=>res.json())
        
}

async function toHtml()
{
    let link = `https://restcountries.com/v3.1/all`;
    let response = await getCountries(link); 
    fillHTML(response)
}


function fillHTML(datas){
    let result = '';
    const charList = document.getElementById('CountryList');
    datas.forEach(el=>{
        result += 
        // `<div class="col-md-3 my-3">
        //     <div class="card">
        //         <img src="${el.imageUrl}" style="height:250px;" class="w-100">
        //         <div class="card-body">
        //             <p class="card-title">${el.name}</p>
        //             <p class="card-text">${el.createdAt}</p>
        //         </div>
        //         <div class="card-footer">
        //             <a href="${el.url}">Get The Page</a>
        //         </div>
        //     </div>
        // </div>`

        `<div class="col-md-4 mb-3">
            <div class="card" style="width: 18rem;">
                <img src="${el.flags.png}" class="card-img-top fuad" alt="...">
                    <div class="card-body">
                        <h5 class="card-title">${el.capital}</h5>
                        <p class="card-text">Some quick example text to build on the card title and make up the bulk of the
                            card's content.</p>
                        <a href="#" class="btn btn-primary">Detail</a>
                    </div>
            </div>
        </div>`
    })
    charList.innerHTML = result;
}

toHtml();

// getCountries('https://restcountries.com/v3.1/all');