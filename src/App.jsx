import { useState } from "react";
import API from "./services/api";
import ClothingSelector from "./components/ClothingSelector";

function App() {

  const [selectedItem, setSelectedItem] = useState("");
  const [result, setResult] = useState(null);
  const [loading, setLoading] = useState(false);

  async function calculate() {

    if (selectedItem === "") {
      alert("Please select a clothing item.");
      return;
    }

    setLoading(true);

    try {

      const response = await API.post("/EcoScan/calculate", {
        items: [selectedItem]
      });

      setResult(response.data);

    } catch (error) {

            console.log(error);
            console.log(error.message);
            console.log(error.response);
            console.log(error.request);

        alert("Could not connect to the API.");

    }

    setLoading(false);
  }

  return (

    <div style={{ width: "500px", margin: "40px auto", textAlign: "center" }}>

      <h1>🌍 eco scan</h1>

      <ClothingSelector
        selectedItem={selectedItem}
        setSelectedItem={setSelectedItem}
        calculate={calculate}
      />

      <br />

      {loading && <p>Calculating...</p>}

      {result &&

        <div>

          <hr />

          <h2>Results</h2>

          <p>
            <strong>Carbon Score:</strong> {result.totalCarbonScore}
          </p>

          <p>
            <strong>Reward Points:</strong> {result.ecoRewardPoints}
          </p>

          <h3>Items</h3>

          <ul>

            {result.items.map((item, index) => (

              <li key={index}>
                {item.name} - {item.carbonScore} kg CO₂
              </li>

            ))}

          </ul>

          <h3>Offers</h3>

          {result.offers.length === 0 ? (

            <p>No offers available.</p>

          ) : (

            <ul>

              {result.offers.map((offer, index) => (

                <li key={index}>{offer}</li>

              ))}

            </ul>

          )}

        </div>

      }

    </div>

  );
}

export default App;