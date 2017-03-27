(function () {
    'use strict'

    angular.module('app').factory('courseService', CourseService);

    CourseService.$inject = ['$http'];

    function CourseService($http) {

        var service = this;

        service.get = function () {
            return $http.get('/api/courses');
        }

        service.getStudents = function (courseId) {
            return $http.get('/api/courses/' + courseId + "/students");
        }

        return service;
    }




}());