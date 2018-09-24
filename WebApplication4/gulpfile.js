/*
This file is the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. https://go.microsoft.com/fwlink/?LinkId=518007
*/

/// <binding BeforeBuild='js, min-css' Clean='js, min-css' />
var gulp = require('gulp'),
    concat = require("gulp-concat"),
    cssmin = require("gulp-cssmin"),
    uglify = require("gulp-uglify");

gulp.task("min-css", function () {

    // Compress site.css and bootstrap.css
    gulp.src(["Content/Styles/global.css"])
        .pipe(concat("Content/Styles/global.min.css"))
        .pipe(cssmin())
        .pipe(gulp.dest("."));

});

gulp.task("js", function () {

    // WebFormsBundle
    gulp.src("Content/Scripts/global.js")
        .pipe(concat("Content/Scripts/global.min.js"))
        .pipe(uglify())
        .pipe(gulp.dest("."));
});
