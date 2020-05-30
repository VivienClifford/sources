/**
 * @jsx React.DOM
 */

'use strict';

var React = require('react');
var {Link} = require('react-router');

var Navbar = React.createClass({
  render() {
    return (
      <div className="navbar-top">
        <div className="container">
        <div className="col-sm-2">
        </div>
        <div className="col-sm-4">
          <Link className="navbar-brand row" to="home">
            <img src="/images/logo-small.png" width="38" height="38" alt="React" />
                {''}
                </Link>
            </div>
        </div>
      </div>
    );
  }
});

module.exports = Navbar;
