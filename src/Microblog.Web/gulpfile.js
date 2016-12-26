var gulp = require('gulp'),
	concat = require('gulp-concat'),
	minify = require('gulp-cssmin'),
	uglify = require('gulp-uglify');

var paths = {
	webroot: "./wwwroot/"
};

paths.jsDest = paths.webroot + "js";
paths.cssDest = paths.webroot + "css";
paths.fontDest = paths.webroot + "fonts";

gulp.task("min:js", function() {
	
});

gulp.task("copy:js", function () {

});

gulp.task("min:css", function () {

});

gulp.task("copy:css", function () {

});

gulp.task("copy:fonts", function () {

});

gulp.task("min", ["min:js", "min:css"]);
gulp.task("copy", ["copy:js", "copy:css", "copy:fonts"]);