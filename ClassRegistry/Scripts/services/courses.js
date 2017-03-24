(function () {
    'use strict'

    angular.module('app').factory('courseService', CourseService);

    FruitService.$inject = ['$http'];

    function CourseService($http) {

        var service = this;

        service.get = function () {
            return $http.get('/api/courses');
        }

        return service;
    }




}());