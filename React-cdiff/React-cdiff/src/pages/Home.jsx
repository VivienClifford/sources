/**
 * @jsx React.DOM
 */
'use strict';
//var NewLineToBr = require('./components/NewLineToBr');

var React = require('react');

var HomePage = React.createClass({
   
    render() {
        return (
        <div className="container">
           <div className="row no-gutters">
                <div className="col-sm-6">
                    <textarea className="form-control" rows="30">
                    <p>{address}</p>
                    </textarea>
                </div>

                <div className="col-sm-6">
                    <textarea className="form-control" rows="30">
                       
                    </textarea>
                  
                </div>
           </div>
        </div>
    );
    }
});
//export default function NewLineToBr({children = ""}){
//    return children.split('\n').reduce(function (arr,line) {
//        return arr.concat(
//          line,
//          <br />
//        );
//    },[]);
//}


module.exports = HomePage;
