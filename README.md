# Bot_with_docker

The purpose of this repository is to test the feasibility of running a web bot from a Docker container. This bot is a console application that can be used to perform Google searches directly from the terminal, returning the first few links of your search query.

### Why a Console App?
To ensure smooth operation within a Docker container, a console application was chosen over a WinForms app, as Docker is more suited to headless, non-GUI operations.

## How to Run

1. **Build the Docker Image:**

   Open a terminal and navigate to the `BotDockerizado` directory. Build the Docker image using the following command:
   ```sh
    docker build -t bot-name .
    ```
2. **Run the Docker Container:**

    Then, run the container with the command
    ```sh
    docker run -t bot-name