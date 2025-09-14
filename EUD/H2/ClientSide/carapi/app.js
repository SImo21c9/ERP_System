const API_URL = "http://ltpe4.web.techcollege.dk/api/CarFamily";

// Fetch all cars and render table
async function loadAndRenderCars() {
    try {
        const response = await fetch(API_URL);
        if (!response.ok) throw new Error(`API returned ${response.status}`);
        const cars = await response.json();
        renderCarsTable(cars);
    } catch (err) {
        alert("Could not load cars: " + err.message);
    }
}

// Dynamically render car objects
function renderCarsTable(cars) {
    const table = document.getElementById("cars-table");
    if (!cars || cars.length === 0) {
        table.innerHTML = "<tr><td>No cars found</td></tr>";
        return;
    }

    // Collect all unique property keys
    const allKeys = [...new Set(cars.flatMap(car => Object.keys(car)))];
    let html = "<thead><tr>";
    for (const key of allKeys) html += `<th>${key}</th>`;
    html += "</tr></thead>";

    html += "<tbody>";
    for (const car of cars) {
        html += "<tr>";
        for (const key of allKeys) {
            html += `<td>${car[key] ?? ""}</td>`;
        }
        html += "</tr>";
    }
    html += "</tbody>";

    table.innerHTML = html;
}

// Add a new car to API
async function addCar(obj) {
    try {
        const response = await fetch(API_URL, {
            method: "POST",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify(obj)
        });
        if (!response.ok) {
            const errorText = await response.text();
            throw new Error("Failed to add car. " + errorText);
        }
        await loadAndRenderCars();
    } catch (err) {
        alert("Could not add car: " + err.message);
    }
}

document.addEventListener("DOMContentLoaded", function() {
    loadAndRenderCars();

    document.getElementById("buyBtn").addEventListener("click", async function() {
        const name = document.getElementById("Name").value;
        const price = Number(document.getElementById("Price").value);
        const year = Number(document.getElementById("Year").value);

        // Build car object (ignores Model field)
        const obj = {
            $type: "car",
            carName: name,
            carYear: year,
            carPrice: price
        };

        // Basic validation
        if (!obj.carName || !obj.carYear || !obj.carPrice) {
            alert("Fill in all required fields (Name, Price, Year).");
            return;
        }

        await addCar(obj);

        // Clear fields
        document.getElementById("Name").value = '';
        document.getElementById("Model").value = '';
        document.getElementById("Price").value = '';
        document.getElementById("Year").value = '';
    });
});