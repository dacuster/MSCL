pipeline {
  agent none
  stages {
    stage('Build') {
      // Run the windows and linux builds in parallel
      parallel {
        stage('Windows') {
          agent { label 'windows10' }
          steps {
            powershell "BuildScripts/jenkins_win.ps1 -buildDir \"${WORKSPACE}\\build\""
            archiveArtifacts artifacts: 'Output/*.zip'
          }
        }
        stage('DEB ARM64') {
          agent { label 'linux-arm64' }
          steps {
            sh ".devcontainer/build-debs.sh --arch arm64v8"
            archiveArtifacts artifacts: 'build_ubuntu_arm64v8/*.deb'
          }
        }
        stage('DEB ARM32') {
          agent { label 'linux-arm' }
          steps {
            sh ".devcontainer/build-debs.sh --arch arm32v7"
            archiveArtifacts artifacts: 'build_ubuntu_arm32v7/*.deb'
          }
        }
        stage('RPM ARM64') {
          agent { label 'linux-arm64' }
          steps {
            sh ".devcontainer/build-rpm.sh --arch arm64v8"
            archiveArtifacts artifacts: 'build_ubuntu_arm64v8/*.deb'
          }
        }
      }
    }
  }
  post {
    failure {
      script {
        if (BRANCH_NAME && (BRANCH_NAME == 'main' || BRANCH_NAME == 'master')) {
          mail to: "melissa.gill@parker.com,rob.fisher@parker.com",
            subject: "Build Failed in Jenkins: ${env.JOB_NAME}",
            body: "See: ${env.BUILD_URL}",
            charset: 'UTF-8',
            mimeType: 'text/html';
        }
      }
    }
    changed {
      script {
        if (BRANCH_NAME && (BRANCH_NAME == 'main' || BRANCH_NAME == 'master') && currentBuild.currentResult == 'SUCCESS') { // Other values: FAILURE, UNSTABLE
          mail to: "melissa.gill@parker.com,rob.fisher@parker.com",
            subject: "Jenkins build is back to normal: ${env.JOB_NAME}",
            body: "See: ${env.BUILD_URL}",
            charset: 'UTF-8',
            mimeType: 'text/html';
        }
      }
    }
  }
}