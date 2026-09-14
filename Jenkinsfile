pipeline {
    agent any
    stages {
        stage('Checkout') {
            steps {
                checkout scm
            }
        }
        stage('Build') {
            steps {
                sh 'dotnet restore'
                sh 'dotnet build --configuration Release --no-restore'
            }
        }
        stage('Test') {
            steps {
                sh 'dotnet test --configuration Release --no-build'
            }
        }
        stage('Package') {
            steps {
                sh 'dotnet pack StudentUtility/StudentUtility.csproj --configuration Release --no-build --output artifacts'
            }
        }
        stage('Publish Artifact') {
            steps {
                archiveArtifacts artifacts: 'artifacts/*.nupkg', fingerprint: true
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deployment Successful'
            }
        }
    }
}