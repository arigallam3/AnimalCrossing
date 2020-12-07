
import React from 'react';

const SearchBar = (props) => {
    return (
        <div className="input-group mb-3 searchBarStyle">
            <div className="input-group-prepend">
                <span className="input-group-text"><strong>Search by:</strong></span>
            </div>
            <div className="search">
                <select name="criteria" className="form-control" onChange={props.handleCriteria} value={props.criteria} >
                    {props.fields.map(entry =>
                        <option key={entry.value} value={entry.value}> {entry.text} </option>
                    )}
                </select>
            </div>
            <div className="search-input">
                <input
                    type="text"
                    className="form-control search-input"
                    aria-label="Default"
                    aria-describedby="inputGroup-sizing-default"
                    name="query"
                    value={props.query}
                    onChange={props.handleSearch}
                />
            </div>
        </div>
    );
}
export default SearchBar;