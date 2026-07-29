function ClothingSelector({ selectedItem, setSelectedItem, calculate }) {

    return (

        <div>

            <select
                value={selectedItem}
                onChange={(e) => setSelectedItem(e.target.value)}
            >

                <option value="">Choose Item</option>

                <option value="T-shirt">T-shirt</option>

                <option value="Jeans">Jeans</option>

                <option value="Jacket">Jacket</option>

                <option value="Shoes">Shoes</option>

            </select>

            <br /><br />

            <button onClick={calculate}>

                Calculate

            </button>

        </div>

    );

}

export default ClothingSelector;