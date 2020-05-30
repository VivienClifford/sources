define(["require", "exports"], function (require, exports) {
    "use strict";
    //Used for line numbers
    function NewLineToBr(_a) {
        var _b = _a.children, children = _b === void 0 ? "" : _b;
        return children.split('\n').reduce(function (arr, line) {
            return arr.concat(line, <br />);
        }, []);
    }
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.default = NewLineToBr;
});
//# sourceMappingURL=NewLineToBr.js.map