var gulp = require('gulp');
var concat = require('gulp-concat');
var cssmin = require('gulp-cssmin');
var uncss = require('gulp-uncss');
var browserSync = require('browser-sync').create();

gulp.task('browser-sync', function(){
    browserSync.init({
        proxy: 'https://localhost:5001'
    });
    gulp.watch('./styles/**/*.css', ['css']);
    gulp.watch('./js/**/*.js', ['js']);
});

//'./node_modules/vue/dist/vue.min.js',
gulp.task('js', function(){
    return gulp.src([
        './node_modules/bootstrap/dist/js/bootstrap.min.js',
        './node_modules/jquery/dist/jquery.min.js',
        './js/site.js'
    ])
    .pipe(gulp.dest('wwwroot/js/'))
    .pipe(browserSync.stream());
});

gulp.task('css', function(){
    return gulp.src([
        './styles/site.css',
        './node_modules/bootstrap/dist/css/bootstrap.css'
    ])
    .pipe(concat('site.min.css'))
    .pipe(cssmin())
    .pipe(uncss({html: ['Views/**/*.cshtml']}))
    .pipe(gulp.dest('wwwroot/css/'))
    .pipe(browserSync.stream());
});

// gulp.task('watch-css', function(){
//    gulp.watch('./styles/**/*.css', ['css'])
// });