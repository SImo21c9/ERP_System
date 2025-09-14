// Change this URL to your backend API base!
const API_URL = "http://localhost:7167/api/cars";

// Render the cars table
function renderCarsTable(cars) {
    const purchasedList = document.getElementById("purchasedList");
    purchasedList.innerHTML = "";
    cars.forEach(car => {
        const row = purchasedList.insertRow();
        row.innerHTML = `<td>${car.name}</td><td>${car.model}</td><td>${car.price}</td><td>${car.year}</td>`;
    });
}

// Fetch all cars from API
async function fetchCars() {
    try {
        const response = await fetch(API_URL);
        if (!response.ok) throw new Error("Failed to fetch cars.");
        const cars = await response.json();
        renderCarsTable(cars);
    } catch (err) {
        alert("Could not load cars: " + err.message);
    }
}

// Add new car to API
async function addCar(car) {
    try {
        const response = await fetch(API_URL, {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(car)
        });
        if (!response.ok) throw new Error("Failed to add car.");
        await fetchCars();
    } catch (err) {
        alert("Could not add car: " + err.message);
    }
}

document.addEventListener("DOMContentLoaded", function() {
    const buyBtn = document.getElementById("buyBtn");
    fetchCars();

    buyBtn.addEventListener("click", async function() {
        const name = document.getElementById("carName").value;
        const model = document.getElementById("carModel").value;
        const price = document.getElementById("carPrice").value;
        const year = document.getElementById("carYear").value;

        if (name && model && price && year) {
            const car = { name, model, price, year };
            await addCar(car);
            document.getElementById("carName").value = '';
            document.getElementById("carModel").value = '';
            document.getElementById("carPrice").value = '';
            document.getElementById("carYear").value = '';
        } else {
            alert("You have to fill all the fields.");
        }
    });
});